using System;
using System.Text;
using StreamerBotTools.Internal;

namespace StreamerBotTools.WindowMover
{
    public class WindowHandle
    {
        public readonly IntPtr hWnd;

        public WindowHandle(IntPtr hWnd)
        {
            this.hWnd = hWnd;
        }

        public string Title
        {
            get
            {
                int size = User32.GetWindowTextLength(hWnd);

                if (size > 0)
                {
                    var builder = new StringBuilder(size + 1);
                    User32.GetWindowText(hWnd, builder, builder.Capacity);
                    return builder.ToString();
                }

                return String.Empty;
            }
        }
    }
}
