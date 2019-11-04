using static System.Console;

namespace EX7 {
    class Program {
		static float med;
		static string[] alunos = new string[50];
		static string[] cpf = new string[50];
		static float[] nota1 = new float[50];
		static float[] nota2 = new float[50];
		static void Main() {
			while (true) {
                WriteLine("ESCOLA VIVA");
                WriteLine("1.Cadastrar nomes");
                WriteLine("2.Cadastrar 1a nota");
                WriteLine("3.Cadastrar 2a nota");
                WriteLine("4.Calcular média");
                WriteLine("5.Lista no monitor");
                WriteLine("6 - Sair");
                int choice = int.Parse(ReadLine());
                Clear();
				if (choice == 6) return;
				switch (choice) {
					case 1:
						Aluno();
						break;
					case 2:
						Nota1();
						break;
					case 3:
						Nota2();
						break;
					case 4:
						CalculaMedia();
						break;
					case 5:
						Listagem();
						break;
					default:
						WriteLine("--------------------------------");
						WriteLine("---------Opção Inválida!--------");
						WriteLine("--------------------------------");
						break;
				}
			}
		}
		static void Aluno() {
			WriteLine("--------------- Cadastro de Alunos ---------------");
			WriteLine("Digite quantos alunos deseja cadastrar (máx 50): ");
			if (!int.TryParse(ReadLine(), out var quantidade) && quantidade <= 50) {
				WriteLine("Quantidade inválida");
				return;
			}
			for (int i = 0; i < quantidade; i++) {
				WriteLine("Digite o nome do aluno: ");
				alunos[i] = ReadLine();
				WriteLine("Digite o cpf do aluno: ");
				cpf[i] = ReadLine();
				WriteLine("\n O códido de cadastro do aluno " + alunos[i] + " é: " + i + " \n");
			}
		}
		static void Nota1() {
			WriteLine("--------------- Cadastro da 1a Nota ----------------");
			WriteLine("Digite o codigo do aluno que deseja cadastrar nota:");
			if (!int.TryParse(ReadLine(), out var codigo)) {
				WriteLine("Código inválido");
				return;
			}
			WriteLine("Digite a 1a nota do aluno " + alunos[codigo]);
			if (!float.TryParse(ReadLine(), out var nota)) {
				WriteLine("Código inválido");
				return;
			}
			nota1[codigo] = nota;
		}
		static void Nota2() {
			WriteLine("--------------- Cadastro da 2a Nota ----------------");
			WriteLine("Digite o codigo do aluno que deseja cadastrar nota:");
			if (!int.TryParse(ReadLine(), out var codigo)) {
				WriteLine("Código inválido");
				return;
			}
			WriteLine("Digite a 2a nota do aluno " + alunos[codigo]);
			if (!float.TryParse(ReadLine(), out var nota)) {
				WriteLine("Código inválido");
				return;
			}
			nota2[codigo] = nota;
		}
		static void CalculaMedia() {
			WriteLine("--------------- Calculo da Media de Notas ----------------");
			WriteLine("Digite o codigo do aluno que deseja calcular média:");
			if (!int.TryParse(ReadLine(), out var codigo)) {
				WriteLine("Código inválido");
				return;
			}
			WriteLine("a media é" + (nota1[codigo] + nota2[codigo]) / 2);
		}
		static void Listagem() {}
    }
}

//https://pt.stackoverflow.com/q/419456/101
