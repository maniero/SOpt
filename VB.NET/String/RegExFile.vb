Dim ItemsCopy As Integer = 0
Dim Caminho As String = ContarItems(I)
Dim SplitCam As String() = Regex.Split(Caminho.ToString, "=")
//tem que pegar um elemento específico (índice 1 é o segundo) e não varrer todo o array
Vizualizador.ListBox1.Items.Add(S(1))

'https://pt.stackoverflow.com/q/40522/101
