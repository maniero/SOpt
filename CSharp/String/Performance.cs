var todasLinhas = new StringBuilder();
foreach (DataRow row in FaturamentoCorpo.Rows)
    todasLinhas += row["ncodigfilia"].ToString();
var paragrafo = todasLinhas.ToString();

//https://pt.stackoverflow.com/q/263447/101
