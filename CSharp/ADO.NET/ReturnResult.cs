private List<componente> ObterLista(string nome_componente) {
    var caminho = new MySqlConnection(@"SERVER=LOCALHOST;DATABASE=portfolio;UID=root;PASSWORD=vertrigo");
    List<componente> lista = new List<componente>();
    var cmd = new MySqlCommand("SELECT * FROM componentes ", caminho);
    caminho.Open();
    MySqlDataReader leitor = cmd.ExecuteReader();
    if (leitor.HasRows) {
        while (leitor.Read()) {
            componente componente = new componente();
            componente.ID = Convert.ToInt32(leitor["id"]);
            componente.NOME = leitor["nome"].ToString();
            componente.LOCAL_ARMAZENAMENTO = leitor["local_armazenamento"].ToString();
            componente.DESCRICAO = leitor["descricao"].ToString();
            lista.Add(componente);
        }
        caminho.Close();
    }
    return lista;
}

//https://pt.stackoverflow.com/q/202124/101
