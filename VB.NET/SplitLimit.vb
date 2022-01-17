Imports System
				
Public Module Module1
	Public Sub Main()
		For Each texto in CropText("Avenida luis de camoes, travessa de santa rita numero 588", 50)
			Console.WriteLine(texto)
		Next
		For Each texto in CropText("Avenida luis de camoes, travessa de santa rita", 50)
			Console.WriteLine(texto)
		Next
		For Each texto in CropText("Avenidaluisdecamoes,travessadesantaritanumero588teste", 50)
			Console.WriteLine(texto)
		Next
	End Sub

	Public Function CropText(text As String, limit As Integer) As String()
		If text.Length < limit
			Return New String() {text}
		Else
			Dim position As Integer = text.LastIndexOf(" ", limit)
			If position = -1
				Return New String() {text}
			Else
				return New String() {text.Substring(0, position), text.Substring(position + 1)}
			End If
		End If
	End Function
End Module

'https://pt.stackoverflow.com/q/213870/101
