using static System.Console;

public class Program {
	public static void Main(string[] args) {
		var textBox1 = "123.45"; //só para facilitar o teste
		var textBox2 = "10"; //só para facilitar o teste
		var textBox3 = "abc"; //só para facilitar o teste
		double SalarioBase;
		if (!double.TryParse(textBox1, out SalarioBase)) { 
			WriteLine("Salario Base foi digitado incorrentamente");
		}
		double Vantagens;
		if (!double.TryParse(textBox2, out Vantagens)) { 
			WriteLine("Salario Base foi digitado incorrentamente");
		}
		double Descontos;
		if (!double.TryParse(textBox3, out Descontos)) { 
			WriteLine("Salario Base foi digitado incorrentamente");
		}
		WriteLine(SalarioBase);
		WriteLine(Vantagens);
	}
}

//https://pt.stackoverflow.com/q/204635/101
