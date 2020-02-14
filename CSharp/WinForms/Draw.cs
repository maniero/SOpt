var f = new Form();
f.BackColor = Color.White;
f.FormBorderStyle = FormBorderStyle.None;
f.Bounds = Screen.PrimaryScreen.Bounds;
f.TopMost = true;
f.TransparencyKey = Color.White;

[DllImport("User32.dll")]
public static extern IntPtr GetDC(IntPtr hwnd);
[DllImport("User32.dll")]
public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);

...


IntPtr desktopPtr = GetDC(IntPtr.Zero);
Graphics g = Graphics.FromHdc(desktopPtr);
var b = new SolidBrush(Color.White);
g.FillRectangle(b, new Rectangle(0, 0, 1920, 1080)); //o algoritmo seria mais sofisticado
g.Dispose();
ReleaseDC(IntPtr.Zero, desktopPtr);

//https://pt.stackoverflow.com/q/143969/101
