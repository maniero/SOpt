using System;
using static System.Console;

namespace ConsoleApplication1 {
	public class Program {
		static int[] Fornecimento(int[] numero) {
//			Clear();
			WriteLine("*****************************************************************");
			WriteLine($"*{new String(' ', 63)}*");
			WriteLine($"*{new String(' ', 16)}FORNECIMENTO DE NUMEROS{new String(' ', 24)}*");
			WriteLine($"*{new String(' ', 63)}*");
			WriteLine("*****************************************************************");
			WriteLine($"\n{new String(' ', 8)}O que deseja fazer: \n\n{new String(' ', 8)}=>1-Fornecer os numeros \n{new String(' ', 8)}=>2-Gerar numeros automaticamente \n\n{new String(' ', 8)}Escolha uma opcao: ");
			int opcao = Convert.ToInt32(ReadLine()); //espero que esta variável vá ser usada em outro lugares
			if (opcao == 1) {
				//espero que vá fazer alguma aqui
			}
			return numero;
		}
		
		public static void Main(string[] args) {
			int[] numero = new int[500000];
			int retorno = 1, tipo = 0; //tipo precisa ser declarada aqui mesmo? no momen to não
			while (retorno == 1) { //este while não faz o menor sentido
//				Clear(); //por alguma razão aqui dá problema executar, mas pode descomentar isso
				WriteLine("*****************************************************************");
				WriteLine($"*{new String(' ', 63)}*");
				WriteLine($"*{new String(' ', 16)}ALGORITMO DE ORDENACAO{new String(' ', 25)}*");
				WriteLine($"*{new String(' ', 63)}*");
				WriteLine("*****************************************************************");
				while (tipo >0 && tipo < 4) {
					//isso é muito gambo, o ideal seria fazer cada linha em um comando próprio, arumei um pouco mas desisti de fazer tudo
					Write($"\n\n{new String(' ', 8)}Que tipo de algoritmo deseja utilizar: \n\n{new String(' ', 8)}1-Inserction sort \n{new String(' ', 8)}2-Selection sort \n{new String(' ', 8)}3-Bubble sort \n\n{new String(' ', 8)}Escolha uma opção=> ");
					tipo = Convert.ToInt32(ReadLine()); //esta convers]ao é insegura, prefira um int.TryParse()
				}
				Fornecimento(numero);
				retorno++;
			}
		}
	}
}

//https://pt.stackoverflow.com/q/131317/101
