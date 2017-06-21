Imports System
				
Public Module Module1
	Public Sub Main()
		Dim Morada As String = "Avenida luis de camoes, travessa de santa rita numero 588"
		Dim limite As Integer = 50
		Dim posicao As Integer = Morada.LastIndexOf(" ", limite)
		If Morada = Nothing OrElse Morada.Length < limite OrElse posicao = -1
			Console.WriteLine(Morada)
		Else
			Console.WriteLine(Morada.Substring(0, Morada.LastIndexOf(" ", limite)))
			Console.WriteLine(Morada.Substring(Morada.LastIndexOf(" ", limite) + 1))
			End If
	End Sub
End Module

'https://pt.stackoverflow.com/q/213870/101
