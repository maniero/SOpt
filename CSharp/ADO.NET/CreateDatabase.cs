using (var connection = new SqlConnection("data source=NomeDoServidor; uid=usuario; pwd=senha;")) {
using (var cmd = new SqlCommand()) {
    connection.Open();
    cmd.Connection = connection;
    cmd.CommandText = "create database NomeDoBancoDeDados;";
    cmd.ExecuteNonQuery();
    cmd.CommandText = "use NomeDoBancoDeDados; create table tabela (ID int, campo1 varchar(20));";
    cmd.ExecuteNonQuery();
}

//https://pt.stackoverflow.com/q/49050/101
