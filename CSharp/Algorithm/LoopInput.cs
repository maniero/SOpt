using static System.Console;
					
namespace CaixaEletronico {
    public class Program {
        public static void Main(string[] args) {
            WriteLine("Caixa Eletronico\n\n");
			var valor = 0;
			while (valor > -1) {
				Write("Digite o valor do saque (-1 para sair): ");
				if (int.TryParse(ReadLine(), out valor) && valor > -1) {
					int notas100 = valor / 100;
					int resto = valor - (notas100 * 100);
					int notas50 = resto / 50;
					resto -= notas50 * 50;
					int notas20 = resto / 20;
					resto -= notas20 * 20;
					int notas10 = resto / 10;
					resto -= notas10 * 10;
					int notas5 = resto / 5;
					resto -= notas5 * 5;
					int notas1 = resto / 1;
					resto -= notas1 * 1;
					WriteLine($"\nQuantidade de notas:\nNotas de 100R$:  {notas100}\n");
					WriteLine($"Notas de 50R$:  {notas50}\n");
					WriteLine($"Notas de 20R$:  {notas20}\n");
					WriteLine($"Notas de 10R$:  {notas10}\n");
					WriteLine($"Notas de 5R$:  {notas5}\n");
					WriteLine($"Notas de 1R$:  {notas1}\n");
				}
			}
        }
    }
}

//https://pt.stackoverflow.com/q/237845/101
