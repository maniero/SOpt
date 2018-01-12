public static void MostraMetodo([CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null) {
    WriteLine($"File: {sourceFilePath}, Method {caller}, Line: {lineNumber} ");
}

var sf = new StackFrame();
sf.GetFileName(), sf.GetMethod(), sf.GetFileLineNumber()

//https://pt.stackoverflow.com/q/267070/101
