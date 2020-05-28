using static System.Console;
using System.Collections.Generic;

namespace ListTeste {
    public class Cidade {
        public string Nome { get; set; }
        public List<Casa> Casas { get; set; } = new List<Casa>();
        public Cidade(string nome, Casa casa) {
            Nome = nome;
            Casas.Add(casa);
        }
		public void NovaCasa(Casa casa) {
			Casas.Add(casa);
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
            var cidade1 = new Cidade("Lisboa", new Casa("João", "verde"));
            var cidade2 = new Cidade("Porto", new Casa("José", "vermelha"));
			cidade1.NovaCasa(new Casa("Joaquim", "azul"));
            WriteLine(cidade1.Casas[0].Dono);
            WriteLine(cidade1.Casas[1].Dono);
        }
    }
}

//https://pt.stackoverflow.com/q/215873/101
