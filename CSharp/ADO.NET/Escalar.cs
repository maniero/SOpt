var valorParaRetornar = (int)Mapped.Command("select max(cur_id) from tbl_curriculo", objConnection).ExecuteScalar();

//https://pt.stackoverflow.com/q/135772/101
