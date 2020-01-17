public object ExecuteNoQueryOperation(string spOrSqlInstructions, CommandType commandType = CommandType.StoredProcedure, Dictionary<string, object> parameters = null) {
    using var npgsqlCommand = new NpgsqlCommand(spOrSqlInstructions, Connection);
    npgsqlCommand.CommandType = commandType;
    if (parameters != null) {
        foreach (var item in parameters) npgsqlCommand.Parameters.Add(new NpgsqlParameter(item.Key, item.Value));
    }
    try { //eu deixei isso, mas não é uma boa ideia
        Connection.Open(); //precisa ter uma forma melhor de controlar abertura
        return npgsqlCommand.ExecuteScalar();
    } finally {
        if (Connection != null && Connection.State != ConnectionState.Closed) Connection.Close();
    }
}

//https://pt.stackoverflow.com/q/132304/101
