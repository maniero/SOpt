Try
    StartPostGrupos()
Catch ex As Exception

End Try

Dim texto As New StreamReader(FILE_NAME). Onde está fechando este stream? Em lugar algum. E mesmo que estivesse, desta forma poderia haver um vazamento se uma exceção ocorresse. Estude o comando Using para evitar estes vazamentos. Com ele você evita que eles ocorram mesmo se uma exceção ocorra.

Using texto As New StreamReader(FILE_NAME)
    'faz tudo o que precisa com esse stream aqui
End Using
    
'https://pt.stackoverflow.com/q/84138/101
