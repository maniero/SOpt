Imports System
Imports Microsoft.VisualBasic

Public Module Module1
	Public Sub Main()
		Console.WriteLine("If")
		If True Then
			Console.WriteLine(x())
		Else
			Console.WriteLine(y())
		End If
		If False Then
			Console.WriteLine(x())
		Else
			Console.WriteLine(y())
		End If
		
		Console.WriteLine("Iif()")
		Console.WriteLine(IIf(True, x(), y()))
		Console.WriteLine(IIf(False, x(), y()))
		
		Console.WriteLine("If()")
		Console.WriteLine(If(True, x(), y()))
		Console.WriteLine(If(False, x(), y()))
				
		Dim number = 12
		Dim divisor = 3
		Console.WriteLine(If(divisor <> 0, number \ divisor, 0))
		Console.WriteLine(IIf(divisor <> 0, number \ divisor, 0))
		divisor = 0
		Console.WriteLine(If(divisor <> 0, number \ divisor, 0))
		'Console.WriteLine(IIf(divisor <> 0, number \ divisor, 0))	'Dá erro aqui			
	End Sub
	Public Function x() As String
		Return "x"
	End Function
	Public Function y() As String
		Return "y"
	End Function
End Module

'https://pt.stackoverflow.com/q/154506/101
