Process[] processoTv = Process.GetProcesses(); //variável só necessária se pretente usar mais tarde
foreach (var processoItem in processoTv) if (processoItem.ProcessName.Contains(teamViewer)) processoItem.Kill();

//https://pt.stackoverflow.com/q/107277/101
