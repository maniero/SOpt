listaNoticia = context.GBV_Noticia.Where(x => x.idPessoa == idPessoa &&
    x.dsConteudo.Contains(WebUtility.HtmlEncode(texto)) && x.icAtivo == "S" &&
    x.dtExclusao == null && x.dtPublicacao <= DateTime.Now &&
    (x.dtForaDoAr == null || x.dtForaDoAr >= DateTime.Now))
    .OrderBy(x =>x.dtPublicacao).ToList();
    
//https://pt.stackoverflow.com/q/81107/101
