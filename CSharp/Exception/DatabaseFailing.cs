public String IdentificarAcessoDAL(FuncionarioDTO acesso) {
    using (var connection = new SqlConnection(connectionString)) {
        var command = new SqlCommand("SELECT CARGO.NOME_CARGO FROM LOGIN INNER JOIN FUNCIONARIO ON FUNCIONARIO.CPF_FUNCIONARIO = LOGIN.CPF_FUNCIONARIO INNER JOIN CARGO ON CARGO.ID_CARGO = FUNCIONARIO.ID_CARGO WHERE LOGIN.USUARIO_LOGIN = '" + acesso.User + "' AND LOGIN.SENHA_LOGIN = '" + acesso.Password + "'", connection);
        command.Connection.Open();
        command.ExecuteNonQuery();
    }
}

//https://pt.stackoverflow.com/q/337830/101
