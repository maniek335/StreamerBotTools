# WindowFinder

## FindWindows()

- **Type**

  ```csharp
  public class WindowFinder {
    public static IEnumerable<WindowHandle> FindWindows(Predicate<WindowHandle> predicate);
  }
  ```

- **Details**

  Finds all windows that pass given predicate.

- **Examples**

  ```csharp{9}
  using StreamerBotTools.WindowMover;

  # Return all windows
  IEnumerable<WindowHandle> windows = WindowFinder.FindWindows(wh => {
    return true;
  });

  # Change the type of IEnumerable to List
  List<WindowHandle> windows = (List)WindowFinder.FindWindows(wh => {
    return true;
  });
  ```

- **See also:**
  - [API - WindowHandle](./WindowHandle)

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
