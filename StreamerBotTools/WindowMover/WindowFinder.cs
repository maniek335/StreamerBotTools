using System;
using StreamerBotTools.Internal;

namespace StreamerBotTools.WindowMover
{
    public class WindowFinder
    {
        public static WindowHandle FindWindow(Predicate<WindowHandle> filter)
        {
            WindowHandle found = null;

            User32.EnumWindows((IntPtr hWnd, IntPtr lParam) =>
            {
                WindowHandle window = new WindowHandle(hWnd);

                if (filter.Invoke(window))
                {
                    found = window;
                    return false;
                }

                return true;
            }, IntPtr.Zero);

            return found;
        }
    }
}
