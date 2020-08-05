using (var conn = new NpgsqlConnection(conn) {           
    conn.Open();
    using (var cmd = new NpgsqlCommand("INSERT INTO public.localpo(NOME) VALUES (:nome)", conn)) {
        cmd.Parameters.Add(new NpgsqlParameter("nome", "Ricardo Soares"));
        var IdInserido = (int)cmd.ExecuteScalar();
    }
}

//https://pt.stackoverflow.com/q/328006/101
