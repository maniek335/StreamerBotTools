using System;

namespace StreamerBotTools.WindowMover
{
    public class WindowHandle
    {
        public readonly IntPtr hWnd;

        public WindowHandle(IntPtr hWnd)
        {
            this.hWnd = hWnd;
        }
    }
}
