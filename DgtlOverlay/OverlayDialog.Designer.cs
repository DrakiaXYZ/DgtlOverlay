namespace DgtlOverlay
{
	partial class OverlayDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.PictureBox pictureLogo;
			this.buttonOkay = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.comboBoxSearch = new System.Windows.Forms.ComboBox();
			pictureLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(pictureLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureLogo
			// 
			pictureLogo.Image = global::DgtlOverlay.Properties.Resources.keepass_32x32;
			pictureLogo.InitialImage = null;
			pictureLogo.Location = new System.Drawing.Point(7, 9);
			pictureLogo.Name = "pictureLogo";
			pictureLogo.Size = new System.Drawing.Size(32, 32);
			pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			pictureLogo.TabIndex = 3;
			pictureLogo.TabStop = false;
			// 
			// buttonOkay
			// 
			this.buttonOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOkay.Location = new System.Drawing.Point(114, 218);
			this.buttonOkay.Name = "buttonOkay";
			this.buttonOkay.Size = new System.Drawing.Size(75, 23);
			this.buttonOkay.TabIndex = 1;
			this.buttonOkay.TabStop = false;
			this.buttonOkay.Text = "Okay";
			this.buttonOkay.UseVisualStyleBackColor = true;
			this.buttonOkay.Click += new System.EventHandler(this.buttonOkay_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(195, 218);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.TabStop = false;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// comboBoxSearch
			// 
			this.comboBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxSearch.BackColor = System.Drawing.SystemColors.Window;
			this.comboBoxSearch.FormattingEnabled = true;
			this.comboBoxSearch.ItemHeight = 16;
			this.comboBoxSearch.Items.AddRange(new object[] {
            ""});
			this.comboBoxSearch.Location = new System.Drawing.Point(43, 13);
			this.comboBoxSearch.Name = "comboBoxSearch";
			this.comboBoxSearch.Size = new System.Drawing.Size(860, 24);
			this.comboBoxSearch.TabIndex = 0;
			// 
			// OverlayDialog
			// 
			this.AcceptButton = this.buttonOkay;
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(915, 50);
			this.ControlBox = false;
			this.Controls.Add(pictureLogo);
			this.Controls.Add(this.comboBoxSearch);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOkay);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OverlayDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Deactivate += new System.EventHandler(this.OverlayDialog_Leave);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OverlayDialog_FormClosing);
			((System.ComponentModel.ISupportInitialize)(pictureLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonOkay;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ComboBox comboBoxSearch;
	}
}