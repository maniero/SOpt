public bool LogarUsuario(string Pnome, string Psenha) {
    using (var conexao = new OleDbConnection(Conexao.stringConn)) {
        conexao.Open();
        var cmd = new OleDbCommand("SELECT * FROM Usuario WHERE Nome = ? AND Senha = ?", conexao);
        cmd.Parameters.Add("@Nome", OleDbType.WChar).Value = Pnome;
        cmd.Parameters.Add("@Senha", OleDbType.WChar).Value = Psenha;
        using (OleDbDataReader reader = cmd.ExecuteReader()) {
            reader.Read();
            if (reader.HasRows) {
                Nome = reader[1];
            }
            return reader.HasRows;
        }
    }
}

//https://pt.stackoverflow.com/q/107892/101
