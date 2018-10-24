public String IdentificarAcessoDAL(FuncionarioDTO acesso) {
    try {
        conexao.cmd.Connection = conexao.conexao;
        conexao.cmd.CommandText = "SELECT CARGO.NOME_CARGO FROM LOGIN INNER JOIN FUNCIONARIO ON FUNCIONARIO.CPF_FUNCIONARIO = LOGIN.CPF_FUNCIONARIO INNER JOIN CARGO ON CARGO.ID_CARGO = FUNCIONARIO.ID_CARGO WHERE LOGIN.USUARIO_LOGIN = '" + acesso.User + "' AND LOGIN.SENHA_LOGIN = '" + acesso.Password + "'";
        conexao.conexao.Open();
        return funcionarioDTO.Funcao = conexao.cmd.ExecuteScalar().ToString();
    } finally {
        conexao.conexao.Close();
    }
}

//https://pt.stackoverflow.com/q/337830/101
