public static List<dMovimentoUser> listar_lancamentos(string conexao) {
    var carrinho = new List<dMovimentoUser>();
    varobjDados = new Dados();
    //temo que esse abreConexao deve estar causando problema também
    using var command = new SqlCommand("usp_lancamentos_internos_listar", objDados.abreConexao();
    command.Parameters.AddWithValue("@conexao", conexao);
    command.CommandType = CommandType.StoredProcedure;
    using var reader = command.ExecuteReader(); //o using garante o fechamento
    //esse abreConexao não deve ter sido escrito do jeito correto também.
    objDados.abreConexao(); //de novo? isso está muito errado
    //já que não está fazendo nada útil com a exceção, é melhor não tratá-la aqui
    //se vai relançar a exceção sem resolver nada, não capture, principalmente Exception
    while (reader.Read()) {
        var ct = new dMovimentoUser();
        ct.codigo = reader["código"].ToString(); //acho que isso pode ser simplificado
        ct.descricao = reader["produto"].ToString();
        ct.data = reader["data"].ToString();
        ct.hora = reader["hora"].ToString();
        ct.operacao = reader["operacao"].ToString();
        ct.qtd = float.Parse(reader["quantidade"].ToString());
        ct.historico = reader["historico"].ToString();
        carrinho.Add(ct);
    }
    return carrinho;
}

//https://pt.stackoverflow.com/q/159519/101
