using static System.Console;

public class Program {
	public static void Main() {
		var objeto = new Classe();
		for (int i = 0; i < 99 ; i++) objeto.campos[i] = "valorqualquer" + i;
		foreach (var item in objeto.campos) WriteLine(item);
	}
	public class Classe {	
		public string[] campos = new string[99];
	}
}

//https://pt.stackoverflow.com/q/382257/101
