public int UltimoItem() {
    using (var con = conexao.obterConexao())
    using (var cmd = new SqlCommand("SELECT MAX(Cod_Item) FROM Pedidos_Itens", con) {
        return Convert.ToInt32(cmd.ExecuteScalar());
    }
}

//https://pt.stackoverflow.com/q/243375/101
