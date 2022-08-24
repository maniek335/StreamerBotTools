# WindowFinder

## FindWindows()

- **Type**

  ```csharp
  public class WindowFinder {
    public static IEnumerable<WindowHandle> FindWindows(Predicate<WindowHandle> predicate);
  }
  ```

- **Details**

  Finds all windows that pass the given predicate.

- **Examples**

  ```csharp{10,14}
  using StreamerBotTools.WindowMover;

  # Return all windows
  IEnumerable<WindowHandle> windows = WindowFinder.FindWindows(wh => {
    return true;
  });

  # Return all windows contains "OBS" in title
  IEnumerable<WindowHandle> windows = WindowFinder.FindWindows(wh => {
    return wh => wh.Title.Contains("OBS");
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

  Find the first window that passes the given predicate.

  ::: warning
  If the window is not found, null is returned.
  :::

- **Examples**

  ```csharp{8}
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
  - [API - WindowFinder.FindWindows()](./WindowFinder#findwindows)
  - [API - WindowHandle](./WindowHandle)

## FindWindowsByTitle()

- **Type**

  ```csharp
  public class WindowFinder {
    public static IEnumerable<WindowHandle> FindWindowsByTitle(string title);
  }
  ```

- **Details**

  Finds all windows containing the specified fragment in the window title.

- **See also:**
  - [API - WindowFinder.FindWindows()](./WindowFinder#findwindows)
  - [API - WindowHandle](./WindowHandle)

## FindWindowByTitle()

- **Type**

  ```csharp
  public class WindowFinder {
    public static WindowHandle FindWindowByTitle(string title);
  }
  ```

- **Details**

  Finds the first window containing the specified fragment in the window title.

  ::: warning
  If the window is not found, null is returned.
  :::

- **See also:**
  - [API - WindowFinder.FindWindow()](./WindowFinder#findwindow)
  - [API - WindowHandle](./WindowHandle)

## GetActiveWindow()

- **Type**

  ```csharp
  public class WindowFinder {
    public static WindowHandle GetActiveWindow();
  }
  ```

- **Details**

  Returns of the currently active (focused) window.

- **See also:**
  - [API - WindowHandle](./WindowHandle)
