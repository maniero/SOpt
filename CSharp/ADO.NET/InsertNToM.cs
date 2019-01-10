try {
    var connection = new MySqlConnection("server=localhost;userid=user;password=1234;database=banco"); 
    connection.Open();
    var transaction = connection.BeginTransaction();

    var command = new MySqlCommand();
    command.Connection = connection;
    command.Transaction = transaction;

    command.CommandText = "INSERT INTO Recibo (ID, AlgumCampo) VALUES (DEFAULT, ?campo1)";
    command.Parameters.AddWithValue("?campo1", dadoDoRecibo);
    command.ExecuteNonQuery();
    var idRecibo = command.LastInsertedId;
    command.CommandText = "INSERT INTO Analise (ID, algumCampo) VALUES (DEFAULT, ?campo1)";
    command.Parameters.AddWithValue("?campo1", dadoDaAnalise);
    var idAnalise = command.LastInsertedId;
    command.ExecuteNonQuery();
    command.CommandText = "INSERT INTO Analise_Recibo (ID, recibo_id, analise_id) VALUES (DEFAULT, ?idRecibo, ?idAnalise)";
    command.Parameters.AddWithValue("?idRecibo", idRecibo);
    command.Parameters.AddWithValue("?idAnalise", idAnalise);
    command.ExecuteNonQuery();

    transaction.Commit();

} catch (MySqlException ex) {
    try { 
        transaction.Rollback();                
    } catch (MySqlException ex) {
        Console.WriteLine("Erro: {0}",  ex.ToString());                
    }
    Console.WriteLine("Erro: {0}",  ex.ToString());
} finally {
    if (connection != null) {
        connection.Close();
    }
}

//https://pt.stackoverflow.com/q/44648/101
