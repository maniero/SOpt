[DllImport("user32.dll")]
public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

[DllImport("user32.dll")]
private static extern IntPtr GetForegroundWindow();

string GetActiveProcessFileName() {
    IntPtr hwnd = GetForegroundWindow();
    uint pid;
    GetWindowThreadProcessId(hwnd, out pid);
    Process p = Process.GetProcessById((int)pid);
    p.MainModule.FileName.Dump();
}

//https://pt.stackoverflow.com/q/130064/101
