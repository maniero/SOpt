using static System.Console;

namespace SalarioAnual {
    public class Program {
        public static void Main() {
            var c = new Calculo();
            WriteLine($"O salário anual é: {c.SalarioAnual}");
        }
    }

    public class Calculo {
		private decimal salarioAnual;
        public int Meses { get; set; } = 12;
		public decimal Salario { get; set; } = 100M;
        public decimal SalarioAnual => Meses * Salario;
    }
}

//https://pt.stackoverflow.com/q/336749/101
