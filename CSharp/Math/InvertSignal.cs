using static System.Console;

namespace POOTeste {
    public class Program2 {
        public static int Main() {
            Write("Digite um número positivo ou negativo: ");
            if (!int.TryParse(ReadLine(), out var numero)) return 1;
            Write($"O valor inverso é {-numero}");
			return 0;
        }
    }
}

//https://pt.stackoverflow.com/q/406973/101
