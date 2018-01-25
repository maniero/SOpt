Imports System
Imports System.Globalization
				
Public Module Module1
	Public Sub Main()
		Dim ptbr = new CultureInfo("pt-br")
		Console.WriteLine("{0}", 123.ToString("N2", ptbr))
		Console.WriteLine("{0}", 123.123.ToString("N2", ptbr))
		Console.WriteLine("{0}", 123123132112321321.123d.ToString("N2", ptbr))
		Console.WriteLine("{0}", 0.123.ToString("N2", ptbr))
		Console.WriteLine("{0}", 0.158123.ToString("N2", ptbr))
	End Sub
End Module

'https://pt.stackoverflow.com/q/271855/101
