Dim con As SqlConnection = New SqlConnection() //criou o objeto
Dim cmd As SqlCommand = New SqlCommand()
con = Nothing // ===============================>abandonou objeto
cmd = Nothing
Try
    'Aqui tenta acessar o objeto que não existe, por isso dá esse erro
    con.ConnectionString = "Server = ;Database=;User Id=;Password = ;"
    
'https://pt.stackoverflow.com/q/186527/101
