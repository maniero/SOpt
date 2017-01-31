using (conexao = new SQLiteConnection(StringDeConexao)) {
    conexao.Open();
    var resultado = conexao.Query("select s.Descricao from Servico s where s.Descricao = @Descricao", new { Descricao = "Descricao de teste" });
    var campoDescricao = resultado[0].Descricao;
}

//http://pt.stackoverflow.com/q/180688/101
