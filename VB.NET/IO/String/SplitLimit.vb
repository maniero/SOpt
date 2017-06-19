Imports System
				
Public Module Module1
	Public Sub Main()
		Dim Morada As String = "Avenida luis de camoes, travessa de santa rita numero 588"
		Dim limite = 50
		If Morada = Nothing Or Morada.Length < limite Or Morada.IndexOf(" ", limite) = -1
			Console.WriteLine(Morada)
		Else
			Console.WriteLine(Morada.Substring(0, Morada.LastIndexOf(" ", limite)))
			Console.WriteLine(Morada.Substring(Morada.LastIndexOf(" ", limite) + 1))
		End If
	End Sub
End Module

'https://pt.stackoverflow.com/q/213870/101
