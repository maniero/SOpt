[StructLayout(LayoutKind.Sequential)]
public struct Point {
    public int X;
    public int Y;

    public static implicit operator Point(Point point) {
        return new Point(point.X, point.T);
    }
}

[DllImport("user32.dll")]
public static extern bool GetCursorPos(out POINT lpPoint);

public static Point GetCursorPosition() {
    Point lpPoint;
    GetCursorPos(out lpPoint);
    //bool success = User32.GetCursorPos(out lpPoint);
    // if (!success)
    return lpPoint;
}

//https://pt.stackoverflow.com/q/153606/101
