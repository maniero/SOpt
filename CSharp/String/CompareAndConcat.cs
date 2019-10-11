private static string MontarDescricaoOrgaoUoUe(RequisicaoFisica requisicao) {
    var texto = "";
    if (!string.IsNullOrEmpty(MontarNomeOrgao(requisicao)) texto = MontarNomeOrgao(requisicao);
    else if (!string.IsNullOrEmpty(MontarNomeUo(requisicao)) texto = MontarNomeUo(requisicao);
    else if (!string.IsNullOrEmpty(MontarNomeUe(requisicao)) texto = MontarNomeUe(requisicao);
    return texto;
}

private static string MontarNomeOrgao(RequisicaoFisica re) => re.CodOrgaoFpe != null && re.CodUoFpe == null && re.CodUeFpe == null && !string.IsNullOrEmpty(re.NomeOrgaoFpe) ?
        re.CodOrgaoFpe + " - " + re.NomeOrgaoFpe :
        "";
        
//https://pt.stackoverflow.com/q/89738/101
