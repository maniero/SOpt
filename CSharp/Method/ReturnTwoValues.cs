public (bool, TipoDoRetornoDoMetodoDadosDermaClube) CarregaProdutosDermaClube(string consulta) {
    var buscaProdutosDermaClube = new BuscaProdutosDermaClubeDAL();
    retorno = this.buscaProdutosDermaClube.DadosDermaClube("");
    if (string.IsNullOrEmpty(consulta)) return (false, null);
    return (retorno[0].idproduto.Contains(consulta), retorno);
}

//https://pt.stackoverflow.com/q/207800/101
