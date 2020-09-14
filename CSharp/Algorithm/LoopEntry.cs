using static System.Console;

public class Program {
    public static void Main() {
        WriteLine("Bem vindo a calculadora do console 0.1 Alpha.");
        int quantNumCalc;
        while (true) {
            WriteLine("Por favor insira quantos números você quer calcular.");
            if (!int.TryParse(ReadLine(), out quantNumCalc) || quantNumCalc < 2) {
                WriteLine("Operação inválida. Digite mais de um número(ERRO 0001)");
                WriteLine("pressione qualquer tecla e aperte enter para tentar novamente.");
                ReadLine();
                Clear();
                continue;
            }
            break;
        }
        var array = CriaArray(quantNumCalc);
    }

    public static int[] CriaArray(int quantidadeNumeros) => new int[quantidadeNumeros];
}

//https://pt.stackoverflow.com/q/471931/101
