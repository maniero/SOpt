public Cliente ObterPorId(int id)
    using (connection) { //imagino que esta informação está disponível na classe
    using (var command = new SqlCommand("SELECT campo1, campo2 FROM Clientes WHERE Id = @id;", connection))
    using (var reader = command.ExecuteReader()) {
        cmd.Parameters.Add(new SqlParameter("@id", id));
        connection.Open();
        Cliente cliente;
        if (reader.Read()) {
            cliente = new Cliente();
            cliente.campo1 = reader.GetString(0) //primeira coluna
            cliente.campo2 = reader.GetString(1) //segunda coluna
        }
    }
    return cliente;
}

//https://pt.stackoverflow.com/q/48993/101
