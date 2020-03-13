Sub macro()
    'Step 1:  Declare your variables.
        Dim MyRange As Range
        Dim MyCell As Range
        Dim i As Double
        i = 6000
    'Step 2:  Define the target Range.
        Set MyRange = Range("A1:T5917")
    'Step 3:  Start looping through the range.
        For Each MyCell In MyRange
    'Step 4:  Do something with each cell.
        MyCell.Cut
        Cells(i, 1).Select
        ActiveSheet.Paste
    'Step 5: Get the next cell in the range
        i = i + 1
        Next MyCell
End Sub

'https://pt.stackoverflow.com/q/154333/101
