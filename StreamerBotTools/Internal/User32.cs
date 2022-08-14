using System;
using System.Runtime.InteropServices;

namespace StreamerBotTools.Internal
{
    internal static class User32
    {
        internal delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        internal static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);
    }
}
