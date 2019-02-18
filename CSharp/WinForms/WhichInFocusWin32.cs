public class MyForm : Form {
      [DllImport("user32.dll", CharSet=CharSet.Auto, CallingConvention=CallingConvention.Winapi)]
      internal static extern IntPtr GetFocus();

      private Control GetFocusedControl() {
           Control focusedControl;
           // To get hold of the focused control:
           IntPtr focusedHandle = GetFocus();
           if(focusedHandle != IntPtr.Zero)
                // Note that if the focused Control is not a .Net control, then this will return null.
                focusedControl = Control.FromHandle(focusedHandle);
           return focusedControl;
      }
}

//https://pt.stackoverflow.com/a/45396/101
