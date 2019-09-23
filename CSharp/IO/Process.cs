Process[] processlist = Process.GetProcesses();
bool rdpclipFound = false;
foreach (Process theprocess in processlist) {
    String ProcessUserSID = GetProcessInfoByPID(theprocess.Id);
    String CurrentUser = WindowsIdentity.GetCurrent().Name.Replace("SERVERNAME\\",""); 
    if (theprocess.ProcessName == "rdpclip" && ProcessUserSID == CurrentUser) {
        theprocess.Kill();
        rdpclipFound = true;
    }
}
Process.Start("rdpclip");
if (rdpclipFound) {
   MessageBox.Show("rdpclip.exe successfully restarted");
} else {
   MessageBox.Show(@"rdpclip was not running under your username.
       It has been started, please try copying and pasting again.");
}

//https://pt.stackoverflow.com/q/80189/101
