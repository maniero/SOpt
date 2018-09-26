var process = new System.Diagnostics.Process { //se usar o using não precisa do namespace
    StartInfo = new ProcessStartInfo {
        StartInfo.FileName = "netstat.exe";
        StartInfo.Arguments = "-abnot";
        StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        RedirectStandardOutput = true;
    }
}
process.Start();
while (!process.StandardOutput.EndOfStream) {
    var line = process.StandardOutput.ReadLine();
    // faz alguma coisa com o conteúdo de cada linha recebida do processo
}

//https://pt.stackoverflow.com/q/41814/101
