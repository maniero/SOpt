using static System.Convert;
using static System.Console;
					
public class Program {
	public static void Main() {
		var exemplo = "13032015joao";
		var dia = ToInt32(exemplo.Substring(0, 2));
		var mes = ToInt32(exemplo.Substring(2, 2));
		var ano = ToInt32(exemplo.Substring(4, 4));
		var nome = exemplo.Substring(8);
		WriteLine(dia);
		WriteLine(mes);
		WriteLine(ano);
		WriteLine(nome);
	}
}

//https://pt.stackoverflow.com/q/54224/101
