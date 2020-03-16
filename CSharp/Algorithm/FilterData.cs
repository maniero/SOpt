using static System.Console;
using System.IO;

namespace ConsoleApplication1 {
	public class Program {
        public static void Main(string[] args) {
            string[] names = new string[6];
            WriteLine("Escolha:\n1 - adicionar\n2 - Visualizar\n 3 - Sair");
            var valor = 0;
			if (!int.TryParse(ReadLine(), out valor)) WriteLine("Opção inválida");
			if (valor == 1) {
                WriteLine("Escreva o nome do autor/grupo, nome do CD, ano de edição, nome da editora, total de tempo e número de faixas: ");
                for (int i = 0; i < 6; i++) names[i] = ReadLine();
				using var sw = new StreamWriter(@"C:\Users\gabri\Desktop\trabalho.txt");
				for (int i = 0; i < 6; i++) sw.WriteLine(names[i]);
			}
			if (valor == 2) {
                WriteLine("FICHEIRO .txt: \n");
				using (var reader = File.OpenText(@"C:\Users\gabri\Desktop\trabalho.txt")) {
					string line;
					while ((line = reader.ReadLine()) != null) WriteLine(line);
				}
                ReadKey();
			}
			if (valor == 3) WriteLine("Adeus");
        }
    }
}

//https://pt.stackoverflow.com/q/158859/101
