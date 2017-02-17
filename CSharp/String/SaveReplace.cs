using static System.Console;
					
public class Program {
	public static void Main() {
		var tt= "{\"Response\":{\"StatusCode\":200,\"StatusMessage\":\"OK\",\"Content\":{\"family\":{\"codigo\":14,\"descricao\":\"Cal\\u00e7a\",\"frontoffice\":1,\"posicaofront\":31,\"posicaoprint\":26,\"fundo\":\"#c0c0c0\",\"letra\":\"#000000\",\"tipo\":0,\"loja\":14,\"subfamilies\":[{\"codigo\":60005,\"descricao\":\"Ganga\",\"familia\":14,\"fundo\":\"#c0c0c0\",\"letra\":\"#000000\",\"posicao\":0,\"loja\":\"14\",\"lastupdate\":\"2015-12-04 16:51:26\"}],\"lastupdate\":\"\",\"famzonas\":[{\"loja\":14,\"familia\":14,\"zona\":0}]}}}}";
        tt = tt.Replace(@"\u00e7", "c");
		WriteLine(tt);
	}
}

//http://pt.stackoverflow.com/q/184837/101
