If mObra.Rows.Count >= 1 Then
   Dim vl_mo_total As Double = 0
   For Each currow2 As DataRow In mObra.Rows
      vl_mo_total += Convert.ToDouble(currow2("vl_maodeobra")) //esta é uma forma simplificada
   Next
End If

'https://pt.stackoverflow.com/q/57117/101
