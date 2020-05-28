using static System.Console;

namespace ArrayTeste {
    public class Cidade {
        public string Nome { get; set; }
        public Casa Casas { get; set; }
        public Cidade(string nome, Casa casas) {
            Nome = nome;
            Casas = casas;
        }
    }
    public class Casa {
        public string Dono { get; set; }
        public string Cor { get; set; }
        public Casa(string dono, string cor) {
            Dono = dono;
            Cor = cor;
        }

    }
    public class Program {
        public static void Main(string[] args) {
			Casa[] casas =  new Casa[2] {
	            new Casa("João", "verde"),
    	        new Casa("José", "vermelha")
			};
            Cidade cidade1 = new Cidade("Lisboa", casas[0]);
            Cidade cidade2 = new Cidade("Porto", casas[1]);
            WriteLine(cidade1.Casas.Dono);
        }
    }
}

//https://pt.stackoverflow.com/q/215873/101
