using static System.Console;

namespace ConsoleApp10 {
	public class Program {
		public static void Main(string[] args) {
			while (true) {
				WriteLine("1 - Conversões");
				WriteLine("2 - Medias");
				WriteLine("0 - Sair");
				WriteLine("Escolha o que deseja fazer: ");
				int menu;
				while (!(int.TryParse(ReadLine(), out menu))) Write("Opção não numerica, digite novamente: ");
				switch (menu) {
					case 2: media(); break;
					case 1: break;
					case 0: WriteLine("Finalizando..."); return;
					default: WriteLine("Nós não temos esta opção, escolhe novamente:"); break;
				}
			}
		}
		static void media() {
			while (true) {
				WriteLine("1 - Média Aritmetica");
				WriteLine("2 - Média Ponderada");
				WriteLine("3 - Voltar");
				WriteLine("Escolha o que deseja fazer: ");
				int menu;
				while (!(int.TryParse(ReadLine(), out menu))) Write("Opção não numerica, digite novamente: ");
				switch (menu) {
					case 1: break;
					case 2: break;
					case 3: return;
					default: WriteLine("Nós não temos esta opção, escolhe novamente:"); break;
				}
			}
		}
	}
}

//https://pt.stackoverflow.com/q/343722/101
