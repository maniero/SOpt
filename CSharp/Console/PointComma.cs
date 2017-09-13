using static System.Console;

public class Program {
    public static void Main(string[] args) {
		System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");
        Write("Digite sua primeira nota: ");
        double n1;
		if (!double.TryParse(ReadLine(), out n1)) {
			Write("nota digitada errada, estou encerrando, pode tentar novamente");
			return;
		}
        Write("Digite sua segunda nota: ");
        double n2;
		if (!double.TryParse(ReadLine(), out n2)) {
			Write("nota digitada errada, estou encerrando, pode tentar novamente");
			return;
		}
        WriteLine($"A Média é {(n1 + n2) / 2}");
    }
}

////https://pt.stackoverflow.com/q/236869/101
