using static System.Console;

namespace Impar_ou_parr {
    public class Program {
        public static void Main(string[] args) {
            WriteLine("Digite uma Palavra: ");
            WriteLine($"Sua palavra tem um numero {(ReadLine().Length % 2 == 0 ? "par" : "ímpar")} de letras");
        }
    }
}

//http://pt.stackoverflow.com/a/176399/101
