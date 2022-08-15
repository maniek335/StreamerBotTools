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
