using static System.Console;

namespace SalarioAnual {
    public class Program {
        public static void Main() {
            Write("Informe o numero de meses trabalhados: ");
            if (!int.TryParse(ReadLine(), out var meses)) return;
            Write("Informe o salário mensal: ");
			if (!decimal.TryParse(ReadLine(), out var salario)) return;
			var c = new Calculo(meses, salario);
            WriteLine($"O salário anual é: {c.SalarioAnual}");
        }
    }

    public class Calculo {
		public Calculo(int meses, decimal salario) {
			Meses = meses;
			Salario = salario;
			SalarioAnual = meses * salario;
		}
		private decimal salarioAnual;
        public int Meses { get; set; }
		public decimal Salario { get; set; }
        public decimal SalarioAnual { get; set; }
    }
}

//https://pt.stackoverflow.com/q/336749/101
