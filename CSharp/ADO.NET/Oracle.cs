using var connection = new OracleConnection(connectionString);
using var command = new OracleCommand("insert into prato (preco) values (:Preco)", connection);
command.Parameters.AddWithValue("Preco", Preco);
command.Connection.Open();
command.ExecuteNonQuery();

//https://pt.stackoverflow.com/q/159079/101
