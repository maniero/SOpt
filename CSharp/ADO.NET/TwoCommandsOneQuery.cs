public static void excluireventos() {
     using var connection = new SqlConnection(Conn.tank());
     connection.Open();
     using var cmd = new SqlCommand("TRUNCATE TABLE Active; TRUNCATE TABLE Active_Number", connection);
     cmd.ExecuteNonQuery();
     Globals.UpdateLogs("Todos os eventos foram excluidos com exito!");
}

//https://pt.stackoverflow.com/q/165639/101
