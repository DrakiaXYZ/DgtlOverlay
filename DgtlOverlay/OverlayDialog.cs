using System;
using System.Drawing;
using System.Windows.Forms;

using KeePass.Plugins;
using KeePassLib;
using KeePassLib.Collections;

namespace DgtlOverlay
{
	public partial class OverlayDialog : Form
	{
		KeyboardHook m_hook = new KeyboardHook();
		IPluginHost m_host = null;

		public OverlayDialog(IPluginHost host)
		{
			InitializeComponent();
			m_host = host;

			// Setup the hook listener and assign our global hotkey (Ctrl+Shift+Space)
			m_hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
			m_hook.RegisterHotKey(DgtlOverlay.ModifierKeys.Control | DgtlOverlay.ModifierKeys.Shift, Keys.Space);
		}

		void hook_KeyPressed(object sender, KeyPressedEventArgs e)
		{
			if (!Utils.IsForegroundFullScreen())
			{
				// TODO: Filter by window title or something in the future?
				PerformSearch("");

				// We have to get the location of the current foreground window before we show our popup
				Rectangle windowRect = Utils.GetForegroundWindowRect();
				Point point = Utils.GetRectCenter(windowRect);

				// Then restore and show our window
				ShowOverlay();

				// Calculate the overlay position based on the previously active window
				this.Left = point.X - (this.Size.Width / 2);
				this.Top = point.Y - (this.Size.Height / 2);

				// Pop the window up over all other windows
				Activate();
			}
			else
			{
				// Don't show (In fact, force hide) the overlay when there's a fullscreen window active.
				// This is to stop us from breaking fullscreen games
				HideOverlay();
			}
		}

		// Don't allow actually closing the form, just hide it
		private void OverlayDialog_FormClosing(object sender, FormClosingEventArgs e)
		{
			HideOverlay();
			e.Cancel = true;
		}

		#region Search Helper Functions
		private void PerformSearch(String sValue)
		{
			PwObjectList<PwEntry> resultList = KeePassHelper.PerformSearch(m_host.Database, sValue);
			if (resultList.UCount > 0)
			{
				PopulateSearchResults(resultList);
			}
			else
			{
				// Should we do something here?
			}
		}

		private void PopulateSearchResults(PwObjectList<PwEntry> resultList)
		{
			// Clear the current list of passwords
			comboBoxSearch.Items.Clear();

			// Add a blank entry
			PasswordEntry peBlank = new PasswordEntry("", null);
			comboBoxSearch.Items.Add(peBlank);

			// Add all of our passwords
			foreach (PwEntry Entry in resultList)
			{
				string sDescription = Entry.Strings.ReadSafe(PwDefs.TitleField);

				PasswordEntry pe = new PasswordEntry(sDescription, Entry);

				comboBoxSearch.Items.Add(pe);
			}

			comboBoxSearch.SelectedIndex = 0;
		}
		#endregion

		#region Overlay Display Helper Functions
		private void OverlayDialog_Leave(object sender, EventArgs e)
		{
			HideOverlay();
		}

		private void HideOverlay()
		{
			this.Visible = false;
		}

		private void ShowOverlay()
		{
			this.Visible = true;
		}
		#endregion

		// This event is called when Escape is hit
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			HideOverlay();
		}

		// This event is called when Enter is hit
		private void buttonOkay_Click(object sender, EventArgs e)
		{
			HideOverlay();

			// Type out just the password.
			// TODO: Allow customization of what we do?
			PasswordEntry pe = comboBoxSearch.SelectedItem as PasswordEntry;
			if (pe != null)
			{
				String Sequence = "{PASSWORD}";
				KeePass.Util.AutoType.PerformIntoCurrentWindow(pe.GetEntry(), m_host.Database, Sequence);
			}
		}
	}
}
