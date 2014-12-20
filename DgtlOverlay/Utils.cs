using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using System.Windows;

namespace DgtlOverlay
{
	class Utils
	{
		[StructLayout(LayoutKind.Sequential)]
		private struct RECT
		{
			public int left;
			public int top;
			public int right;
			public int bottom;
		}

		[DllImport("user32.dll")]
		private static extern bool GetWindowRect(HandleRef hWnd, [In, Out] ref RECT rect);
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		public static bool IsForegroundFullScreen()
		{
			IntPtr currentWindowHandle = GetForegroundWindow();
			Screen screen = Screen.FromHandle(currentWindowHandle);

			RECT rect = new RECT();
			GetWindowRect(new HandleRef(null, currentWindowHandle), ref rect);
			return new Rectangle(rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top).Contains(screen.Bounds);
		}

		public static Rectangle GetForegroundWindowRect()
		{
			IntPtr currentWindowHandle = GetForegroundWindow();

			RECT rect = new RECT();
			GetWindowRect(new HandleRef(null, currentWindowHandle), ref rect);

			return new Rectangle(rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top);
		}

		public static Point GetRectCenter(Rectangle windowRect)
		{
			return new Point(windowRect.Right - (windowRect.Width / 2), windowRect.Bottom - (windowRect.Height / 2));
		}
	}
}
