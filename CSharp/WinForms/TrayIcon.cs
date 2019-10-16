static class Program {
    [STAThread]
    static void Main() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Application.Run(new MyCustomApplicationContext());
    }
}


public class MyCustomApplicationContext : ApplicationContext {
    private NotifyIcon trayIcon;

    public MyCustomApplicationContext() {
        trayIcon = new NotifyIcon() {
            Icon = Resources.AppIcon,
            ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Exit", Exit)
            }),
            Visible = true
        };
    }

    void Exit(object sender, EventArgs e) {
        // Hide tray icon, otherwise it will remain shown until user mouses over it
        trayIcon.Visible = false;
        Application.Exit();
    }
}

//https://pt.stackoverflow.com/q/91100/101
