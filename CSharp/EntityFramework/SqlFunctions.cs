query = query.Where(x => Convert.ToString(x.MeuCampoInteiro).Contains(filter));

query = query.Where(x => SqlFunctions.StringConvert(x.MeuCampoInteiro).Contains(filter));

//https://pt.stackoverflow.com/q/241040/101
