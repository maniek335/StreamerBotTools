# WindowFinder

## FindWindow()

- **Type**

  ```csharp
  public class WindowFinder {
    public static WindowHandle FindWindow(Predicate<WindowHandle> predicate);
  }
  ```

- **Details**

  Find first window that pass given predicate.

  ::: warning
  If window is not found, null is returned.
  :::

- **Examples**

  ```csharp
  using StreamerBotTools.WindowMover;

  WindowHandle window = WindowFinder.FindWindow(wh => {
    return true;
  });

  /* Check if the window is found */
  if (window != null) {
    /* do enything with the window */
  }
  ```

- **See also:**
  - [API - WindowHandle](./WindowHandle)
