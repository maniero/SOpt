bool lockWasTaken = false;
var temp = padlock;
try {
    Monitor.Enter(temp, ref lockWasTaken);
    Directory.CreateDirectory(Dir);
    File.AppendAllText(FilePath, content);
} finally {
    if (lockWasTaken) Monitor.Exit(temp);
}

//https://pt.stackoverflow.com/q/254196/101
