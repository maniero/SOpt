public IEnumerable<string> PegaLista() {
    //cria a conexão garantindo que ela será fechada. A string é pega do arquivo de configuração
    //É possível a string de conexão pegar da fonte que você quiser
    using (var connection = new SqlConnection(Properties.Settings.Default.DBConnectionString))
    //cria uma *query* garantindo que ela será encerrada ao final
    using (var cmd = connection.CreateCommand()) {
        connection.Open(); //abre conexão
        cmd.CommandText = "select COUNT(CodEstabelecimento) as contagem from TBEstabelecimentos"; //define a query p/ o DB
        using (var reader = cmd.ExecuteReader()) { //cria um leitor do ADO.Net
            while (reader.Read()) { //vai lendo cada item do resultado do select
                //retorna sob demanda cada item encontrado
                yield return reader.GetString(reader.GetOrdinal("contagem"));
            }
        }
    }
}

//https://pt.stackoverflow.com/q/44795/101
