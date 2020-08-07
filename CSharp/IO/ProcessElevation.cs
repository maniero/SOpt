if (!IsAdministrator()) {
    // Restart program and run as admin
    var exeName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
    ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
    startInfo.Verb = "runas";
    System.Diagnostics.Process.Start(startInfo);
    Application.Current.Shutdown();
    return;
}
private static bool IsAdministrator() {
    WindowsIdentity identity = WindowsIdentity.GetCurrent();
    WindowsPrincipal principal = new WindowsPrincipal(identity);
    return principal.IsInRole(WindowsBuiltInRole.Administrator);
}

//https://pt.stackoverflow.com/q/332686/101
