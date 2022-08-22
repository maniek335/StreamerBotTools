using System;
using System.Drawing;
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

        public Rectangle GetWindowRectangle()
        {
            User32.GetWindowRect(hWnd, out RECT rect);

            return Rectangle.FromLTRB(rect.Left, rect.Top, rect.Right, rect.Bottom);
        }

        public bool SetWindowPos(Rectangle rect)
        {
            return User32.SetWindowPos(
                hWnd: hWnd,
                hWndInsertAfter: IntPtr.Zero,
                X: rect.X,
                Y: rect.Y,
                cx: rect.Width,
                cy: rect.Height,
                uFlags: 0);
        }

        public bool Resize(int widthOffset, int heightOffset)
        {
            var rect = GetWindowRectangle();

            rect.Width += widthOffset;
            rect.Height += heightOffset;

            return SetWindowPos(rect);
        }

        public bool ResizeTo(int newWidth, int newHeight)
        {
            var rect = GetWindowRectangle();

            rect.Width = newWidth;
            rect.Height = newHeight;

            return SetWindowPos(rect);
        }

        public bool Move(int xOffset, int yOffset)
        {
            var rect = GetWindowRectangle();

            rect.X += xOffset;
            rect.Y += yOffset;

            return SetWindowPos(rect);
        }

        public bool MoveTo(int newX, int newY)
        {
            var rect = GetWindowRectangle();

            rect.X = newX;
            rect.Y = newY;

            return SetWindowPos(rect);
        }
    }
}
