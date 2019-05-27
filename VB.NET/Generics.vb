Private Sub CarregarArraysPeloDgv(Of T)(ByRef dgv As DataGridView, ByRef a() As T)
    ' REDIMENSIONAR
    If a Is Nothing Then
        ReDim a(dgv.Rows.Count - 1)
        Exit Sub
    End If

    If dgv.Rows.Count > a.Count Then
        ReDim a(dgv.Rows.Count - 1)
    End If

    ' ALIMENTAR
    Dim x As Integer = 0
    For Each row As DataGridViewRow In dgv.Rows
        a(x) = Val(row.Cells(0).Value)
        x = x + 1
    Next
End Sub

'https://pt.stackoverflow.com/q/386646/101
