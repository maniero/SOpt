using MySqlCommand cmd = new(@"SELECT idaluno, nomealuno, responsavel, cpf, rg, fone_contato, desistente FROM aluno WHERE (idaluno = 12 OR nomealuno LIKE '%' @nomealuno '%' OR cpf = @cpf)"), new MySqlConnection("passe_sua_string_de_conexao"));
cmd.Parameters.AddWithValue("@nomealuno", nome);
cmd.Parameters.AddWithValue("@cpf", cpf);

//https://pt.stackoverflow.com/q/26719/101
