'isto possivelmente vai no Main
Dim currentDomain = AppDomain.CurrentDomain
currentDomain.UnhandledException += new unhandledExceptionEventHandler(MyHandler)

Shared Sub MyHandler(object sender, UnhandledExceptionEventArgs args) {
   Dim e =  DirectCast(args.ExceptionObject, Exception)
   Console.WriteLine("Erro: {0}", e.Message)
   'aqui você pode fazer o que quiser
End Sub

'https://pt.stackoverflow.com/q/48834/101
