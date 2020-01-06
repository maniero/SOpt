Imports System
Public Module Module1
	Public Sub Main()
		Dim itens As String() = {"000.000.000-00;Maria da Silva;1995", "111.111.111-11;José de Souza;2005", "222.222.222-22;João Antônio;1945"}
		Dim posicao As String = String.Join("", itens)
		Dim separa As String()
		Dim contagem As String
		
		contagem = itens.Length
		
		Dim i As Integer
		For i = 0 To contagem
			separa = posicao.Split(";")
			Dim cpf = separa(0)
			Dim nome = separa(1)
			Dim anonasc = separa(2)
			Console.WriteLine(cpf)
			Console.WriteLine(nome)
			Console.WriteLine(anonasc)

		Next
End Sub
End Module

'https://pt.stackoverflow.com/q/126252/101
