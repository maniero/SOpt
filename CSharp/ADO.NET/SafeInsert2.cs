var cmd = new SqlCommand("INSERT INTO tb_Instrumento SET Identificacao = @Identificao, Descricao = @Descricao, ... aqui vai colocar todos os campos ..., Certificado = @Certificado, ... pode ter outros aqui", connection);

cmd.Parameters["@Identificacao"].Value = identificacaoTextBox.Text;
cmd.Parameters["@Descricao"].Value = descricaoTextBox.Text;
... todos os parâmetros aqui
cmd.Parameters["@Certificado"].Value = txb_caminho.Text;

//https://pt.stackoverflow.com/q/136287/101
