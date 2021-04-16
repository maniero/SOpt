using (var connection = new SqlConnection(connectionString))
using (var command = new SqlCommand("UPDATE cliente SET nome = @nome, email = @email WHERE id = @id;", connection) {
    command.Parameters.Add("@id", SqlDbType.Int);
    command.Parameters["@id"].Value = dto.Id;
    command.Parameters.AddWithValue("@nome", dto.Nome);
    command.Parameters.AddWithValue("@email", dto.Email);
    connection.Open();
    command.ExecuteNonQuery();
}

//https://pt.stackoverflow.com/q/393479/101
