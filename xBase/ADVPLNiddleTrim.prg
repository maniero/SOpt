Function MiddleTrim(cText)
    Local cClean := ""
    Local cLast := " "
    Local nLen := Len(cText)
    Local i
    Local cChar
    For i := 1 To nLen
        cChar := Substr(cText, i, 1)
        If cChar != " "
            cClean += cChar
        ElseIf cLast != " "
            cClean += " "
        EndIf
        cLast := cChar
    Next
    If Substr(cClean, Len(cClean), 1) == " "
        cClean := Substr(cClean, 1, Len(cClean) - 1)
    EndIf
Return cClean

//https://pt.stackoverflow.com/q/242618/101
