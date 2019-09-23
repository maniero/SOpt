if (!decimal.TryParse(mkd_ValorProduto.Text, out var valor) {
    //tratar o erro aqui
}
cmd.Parameters.AddWithValue("Valor", valor);

//https://pt.stackoverflow.com/q/411497/101
