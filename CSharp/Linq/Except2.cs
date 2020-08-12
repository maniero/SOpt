var listaProdutosDiferentes = listaPrincipalProdutos.Except(listaFinalProdutos);

var listaProdutosDiferentes = listaPrincipalProdutos.Except(listaFinalProdutos).Concat(listaFinalProdutos.Except(listaPrincipalProdutos));

var listaProdutosDiferentes = listaPrincipalProdutos.Intersect(listaFinalProdutos);

//https://pt.stackoverflow.com/q/339880/101
