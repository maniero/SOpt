public Conta LoginCliente(string agencia, string conta) {
    DAO.SQL conexao = new DAO.SQL();
    conexao.AbrirConexao(); //esta classe deveria adotar o padrão Disposable
    Conta cliente = conexao.ConsultarCliente(agencia, conta);
    conexao.FecharConexao(); //se der exceção isto nunca será executado
    return cliente;
}

//https://pt.stackoverflow.com/q/219705/101
