var connectionString = "Data Source=MSSQL;Initial Catalog=SeuBanco; Integrated Security=true;";
using (var connection = new SqlConnection()) {
    connection.ConnectionString = connectionString;
    connection.Open();
    Console.WriteLine("Estado: {0}", connection.State);
    Console.WriteLine("ConnectionString: {0}", connection.ConnectionString);
}

//https://pt.stackoverflow.com/q/46372/101
