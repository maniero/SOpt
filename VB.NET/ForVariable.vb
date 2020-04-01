Imports System
				
Public Module Module1
	Public Sub Main()
		Metodo()
		Console.WriteLine()
		Metodo2()
	End Sub
	Private Sub Metodo()
		Dim MeuTipo As Tipo
	
		For i As Integer = 0 To 100
			MeuTipo = New Tipo
			MeuTipo.FacaAlgumaCoisa()
		Next
	End Sub
	
	Private Sub Metodo2()    
		For i As Integer = 0 To 100
			Dim MeuTipo As New Tipo
			MeuTipo.FacaAlgumaCoisa()
		Next
	End Sub
End Module

Public Class Tipo
	Public Sub FacaAlgumaCoisa()
		Console.Write("x")
	End Sub
End Class

'https://pt.stackoverflow.com/q/172697/101
