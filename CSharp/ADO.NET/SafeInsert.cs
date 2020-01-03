var sqlInsert = new SqlCommand(@"Insert into dependente (id_funcionario, nome, grau_parentesco, data_nascimento)
                    VALUES (@id_funcionario, @nome, @grau_parentesco, @data_nascimento)", conn);
sqlInsert.Parameters.AddWithValue("@id_funcionario", bDep.Funcionario.Id_funcionario);
sqlInsert.Parameters.AddWithValue("@nome", bDep.Nome);
sqlInsert.Parameters.AddWithValue("@grau_parentesco", bDep.Grau_parentesco);
sqlInsert.Parameters.AddWithValue("@data_nascimento", bDep.Data_nascimento.ToShortDateString());
sqlInsert.ExecuteNonQuery();

//https://pt.stackoverflow.com/q/125732/101
