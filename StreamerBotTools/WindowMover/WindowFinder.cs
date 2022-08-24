using System;
using System.Collections.Generic;
using System.Linq;
using StreamerBotTools.Internal;

namespace StreamerBotTools.WindowMover
{
    public class WindowFinder
    {
        public static IEnumerable<WindowHandle> FindWindows(Predicate<WindowHandle> filter)
        {
            IEnumerable<WindowHandle> windows = Enumerable.Empty<WindowHandle>();

            User32.EnumWindows((IntPtr hWnd, IntPtr lParam) =>
            {
                WindowHandle window = new WindowHandle(hWnd);

                if (filter.Invoke(window)) windows.Append(window);

                return true;
            }, IntPtr.Zero);

            return windows;
        }

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

        public static IEnumerable<WindowHandle> FindWindowsByTitle(string title)
            => FindWindows(wh => wh.Title.Contains(title));

        public static WindowHandle FindWindowByTitle(string title)
            => FindWindow(wh => wh.Title.Contains(title));

        public static WindowHandle GetActiveWindow() => new WindowHandle(User32.GetForegroundWindow());
    }
}
