using System;
using static System.Math;
using static System.Console;
					
public class Program {
	public static void Main() {
        WriteLine("Bem vindo a calculadora de áreas!!!");
        WriteLine("A seguir escolha qual figura deseja, digitando o número correspondente a figura correspondente.");
        WriteLine("1 ==> Quadrado");
        WriteLine("2 ==> Triângulo");
        WriteLine("3 ==> Circunferência");
        string escolha = ReadLine();
        int opcao;
        if (!int.TryParse(escolha, out opcao)) {
            Write("Opção inválida");
            return;
        }
        switch (opcao) {
            case  1:
                int lado;
                WriteLine("Digite o valor do lado do quadrado: ");
				string texto = ReadLine();
				if (!int.TryParse(escolha, out lado)) {
					Write("Número inválido");
					return;
				}
                lado = lado * lado;
				WriteLine($"O valor da área do quadrado e: {lado}");
                break;
            case  2:
                int base_t, altura, resultado;
                WriteLine("Digite o valor da base do triângulo: ");
				texto = ReadLine();
				if (!int.TryParse(escolha, out base_t)) {
					Console.Write("Número inválido");
					return;
				}
                WriteLine("Digite o valor da altura do triângulo: ");
				texto = ReadLine();
				if (!int.TryParse(escolha, out altura)) {
					Write("Número inválido");
					return;
				}
                resultado = base_t * altura / 2;
				WriteLine($"O valor da área do triângulo é: {resultado}");
                break;
            case  3:
                int raio;
                double area;
                WriteLine("Digite o valor do raio da circunferência: ");
				texto = ReadLine();
				if (!int.TryParse(escolha, out raio)) {
					Write("Número inválido");
					return;
				}
                area = PI * (raio * raio);
				WriteLine($"O valor da área do circunferência e: {area}");
                break;
        }
	}
}

//https://pt.stackoverflow.com/q/140106/101
