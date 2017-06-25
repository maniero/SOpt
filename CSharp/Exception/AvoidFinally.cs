using System;
using static System.Console;

namespace Calculadora {
    public class Program {
        public static void Main(string[] args) {
            try {
                WriteLine("Digite o primeiro numero.");
				double n1 = double.Parse(ReadLine());
                WriteLine("Digite o segundo numero.");
                double n2 = double.Parse(ReadLine());
                double multiplicacao = n1 * n2;
                WriteLine("Resultado...");
				WriteLine($"{n1} * {n2} = {multiplicacao}");
            } catch (Exception) { //só para efeitos de teste, caso contrário não capture Exception
                WriteLine("Erro ao tentar fazer a conta."); //na prática agora nunca acontecerá a exceção
				WriteLine("O finally nao foi executou.");
                return;
            }
            WriteLine("Tudo foi executado...");
        }
    }
}

//https://pt.stackoverflow.com/q/215379/101
