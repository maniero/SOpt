using static System.Console;

namespace SalarioAnual {
    public class Program {
        public static void Main() {
            var c = new Calculo();
            Write("Informe o numero de meses trabalhados: ");
            if (!int.TryParse(ReadLine(), out var meses)) return;
			c.Meses = meses;
            Write("Informe o salário mensal: ");
			if (!decimal.TryParse(ReadLine(), out var salario)) return;
            c.Salario = salario;
            WriteLine($"O salário anual é: {c.SalarioAnual}");
        }
    }

    public class Calculo {
		private decimal salarioAnual;
        public int Meses { get; set; }
		public decimal Salario { get; set; }
        public decimal SalarioAnual => Meses * Salario;
    }
}

//https://pt.stackoverflow.com/q/336749/101
