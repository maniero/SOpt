public List<Estabelecimento> listaEstabelecimento(string ibge) {
    List<Estabelecimento> listaestabelecimento = new List<Estabelecimento>();
    var caminho = HttpContext.Current.Server.MapPath("~/Content/txtCnes/" + ibge);
    //como saber se a variável 'caminho' é um diretório válido? caso não seja, como criá-lo?
    try {
        var file = new StreamReader($"{caminho}/lfces004.txt", Encoding.GetEncoding("iso-8859-1"));
        // provavelmente terá algo para fazer aqui para fazer sentido
    } catch (DirectoryNotFoundException) {
         WriteLine("o caminho não existe");
         return null; // provavelmente, não vi todo o código
    }
}

//https://pt.stackoverflow.com/q/243587/101
