using System;

using KeePass.Plugins;

namespace DgtlOverlay
{
    public sealed class DgtlOverlayExt : Plugin
    {
		private IPluginHost m_host = null;
		OverlayDialog m_dialog = null;

		public override bool Initialize(IPluginHost host)
		{
			m_host = host;
			m_dialog = new OverlayDialog(host);

			return true;
		}
    }
}
