comando.CommandText = @"select nome as Nome,  
        endereco as Endereço,
        telefone as Telefone,
        dataCadastro as [Data de Cadastro]
    from clientes
    where dataCadastro = @Periodo and status<>'0'";
comando.Parameters.Add("@Periodo", OleDbType.VarChar, 10).Value = dePeriodo.Text;

//https://pt.stackoverflow.com/q/340204/101
