if (!decimal.TryParse(item.SubItems[2].Text, out var quantidade)) //faz alguma coisa se deu erro e encerra a execução

var resultado = cmdQry.ExecuteScalar();
if (resultado == DBNull.Value) //faz alguma coisa aqui para tratar o erro e encerra
var soma = ToDecimal(resultado);

//https://pt.stackoverflow.com/q/357577/101
