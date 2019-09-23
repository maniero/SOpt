static void KillProcessByNameAndUserName(string processName, string userName) {
    var processes = from p in Process.GetProcessesByName(processName)
                    where GetProcessOwner(p.Id) == userName
                    select p;
    foreach(Process p in processes) p.Kill();
}

static string GetProcessOwner(int processId) {
    string query = “Select * From Win32_Process Where ProcessID = “ + processId;
    ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
    ManagementObjectCollection processList = searcher.Get();
    foreach (ManagementObject obj in processList) {
        string[] argList = new string[] { string.Empty };
        int returnVal = Convert.ToInt32(obj.InvokeMethod(“GetOwner”, argList));
        if (returnVal == 0)
            return argList[0];
    }
    return “NO OWNER”;
}

//https://pt.stackoverflow.com/q/80189/101
