Private Sub Metodo(Of TSource)(Expressao As Func(Of TSource, Boolean))
    Lista = Lista.Where(Expressao)
End Sub

Private Sub Metodo(Expressao As Func(Of Integer, Boolean))
    Lista = Lista.Where(Expressao)
End Sub

Metodo(Function(x) x = 0)

'https://pt.stackoverflow.com/q/172710/101
