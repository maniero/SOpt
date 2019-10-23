string sql = "select max(end_id) from endereco";
SqlCommand cmd = new SqlCommand(sql, con);
con.Open();
return ((int)cmd.ExecuteScalar()).ToString();

//https://pt.stackoverflow.com/q/94893/101
