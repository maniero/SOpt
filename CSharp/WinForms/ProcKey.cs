// DLL libraries used to manage hotkeys
[DllImport("user32.dll")] 
public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
[DllImport("user32.dll")]
public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

const int MYACTION_HOTKEY_ID = 1;

// Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
// Compute the addition of each combination of the keys you want to be pressed
// ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 6, (int) Keys.F12);

protected override void WndProc(ref Message m) {
    if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID) {
        // My hotkey has been typed

        // Do what you want here
        // ...
    }
    base.WndProc(ref m);
}

//https://pt.stackoverflow.com/q/185083/101
