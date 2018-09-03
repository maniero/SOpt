using static System.Console;

namespace testando {
	class Program {
		public static void Main() {
			WriteLine("Escreva 1 para apresentar 'olá' na tela ou só <enter> para sair");
			if (ReadLine() == "1") Falar();
		}
		public static void Falar() => WriteLine("Olá meu nome é ninguém");
	}
}

//https://pt.stackoverflow.com/q/326798/101
