# WindowHandle

## Constructor

- **Type**

  ```csharp
  public class WindowHandle {
    public WindowHandle(IntPtr hWnd);
  }
  ```

## hWnd

- **Type**

  ```csharp
  public class WindowHandle {
    public readonly IntPtr hWnd;
  }
  ```

  - **Details**

  Returns the hWnd of the window.

## Title

- **Type**

  ```csharp
  public class WindowHandle {
    public string Title { get; }
  }
  ```

- **Details**

  Returns the title of the window.

- **See also:**
  - [API - WindowFinder.FindWindowsByTitle()](./WindowFinder#findwindowsbytitle)
  - [API - WindowFinder.FindWindowByTitle()](./WindowFinder#findwindowbytitle)

## GetWindowRectangle()

- **Type**

  ```csharp
  public class WindowHandle {
    public System.Drawing.Rectangle GetWindowRectangle();
  }
  ```

- **See also:**
  - [Microsoft Docs - Rectangle](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.rectangle)

## SetWindowPos()

- **Type**

  ```csharp
  public class WindowHandle {
    public bool SetWindowPos(System.Drawing.Rectangle rect);
  }
  ```

- **See also:**
  - [Microsoft Docs - Rectangle](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.rectangle)

## Resize()

- **Type**

  ```csharp
  public class WindowHandle {
    public bool Resize(int widthOffset, int heightOffset);
  }
  ```

- **Details**

  Resizes the window relative to its current size.

## ResizeTo()

- **Type**

  ```csharp
  public class WindowHandle {
    public bool ResizeTo(int newWidth, int newHeight);
  }
  ```

- **Details**

  Resizes the window to a new width and height.

## Move()

- **Type**

  ```csharp
  public class WindowHandle {
    public bool Move(int xOffset, int yOffset);
  }
  ```

- **Details**

  Moves the window relative to its current position.

## MoveTo()

- **Type**

  ```csharp
  public class WindowHandle {
    public bool MoveTo(int newX, int newY);
  }
  ```

- **Details**

  Moves the window to new coordinates on the screen.
