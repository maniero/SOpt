using (var connection = new SqlConnection(connectionString)) {
    var query = "SELECT nome, idade FROM Pessoas ";
    if (nome != "") query += " WHERE nome LIKE '%@Nome%'";
    query += " ORDER BY idade"; //deixei mas poderia otimizar isto
    var command = new SqlCommand(query, connection);
    command.Parameters.Add("@Nome", SqlDbType.NVarChar);
    command.Parameters["@Nome"].Value = nome;
    try {
        connection.Open();
        int rowsAffected = command.ExecuteNonQuery();
    }
    catch (SQLException ex) {
        Console.WriteLine(ex.Message); //só exemplo, deveria fazer algo mais
    }
}

var query = new StringBuilder("SELECT nome, idade FROM Pessoas ");
if (nome != "") query.Append(" WHERE nome LIKE '%@Nome%'");
query.Append(" ORDER BY idade"); //deixei mas poderia otimizar isto

//https://pt.stackoverflow.com/q/104614/101
