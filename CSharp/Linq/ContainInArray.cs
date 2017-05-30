using static System.Console;
using System.Linq;

public class Program {
	public static void Main() {
		string[] nomes = { "misael", "camila", "fernando" };
		var txtBusca = "camila";
	    if (nomes.Contains(txtBusca)) {
            WriteLine("Nome encontrado");
		} else {
			WriteLine("Nome não encontrado");
		}
	}
}

//https://pt.stackoverflow.com/q/208601/101
