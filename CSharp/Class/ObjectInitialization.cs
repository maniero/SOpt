using System.Collections.Generic;

public class Program {
	public static void Main() {
		Arquivo arquivo = new Arquivo();
		ArquivoVersao versao = new ArquivoVersao();
		versao.XNOME = "teste";
		var list = new List<ArquivoVersao>();
		list.Add(versao);
		arquivo.ArquivoVersoes = list;
		//arquivoVersoes é uma lista de Versoes
	}
}

public class Arquivo {
    public string ARQUIVO_GUID { get; set; }
    public string XARQUIVO { get; set; }
    public string TAG { get; set; }
    public string EXTENSAO { get; set; }
    public string URL { get; set; }
    public bool IS_STREAM { get; set; }
    public string ULT_ARQUIVO_VERSAO_GUID { get; set; }
    public string TIPO_DE_ARQUIVO_GUID { get; set; }
    public string DIRETORIO_GUID { get; set; }
//    public TipoDeArquivo TipoDeArquivo { get; set; }
    public List<ArquivoVersao> ArquivoVersoes { get; set; }
}


public class ArquivoVersao {
        public string XNOME { get; set; }
}

//https://pt.stackoverflow.com/q/49774/101
