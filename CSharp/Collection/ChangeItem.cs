using static System.Console;
using System.Collections.Generic;

namespace ListaObjeto {
    public class Pessoa {
        public Pessoa() {
            Nome = "";
            Idade = 0;
        }

		public Pessoa(string nome, int idade) {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
         public int Idade { get; set; }
    }

    public class Program {
        public static void Main(string[] args) {
            var listaPessoa = new List<Pessoa>();
			listaPessoa.Add(new Pessoa("João", 18));
			listaPessoa.Add(new Pessoa());
			foreach (var pessoa in listaPessoa) WriteLine($"Nome: {pessoa.Nome} - Idade {pessoa.Idade}");
        }
    }
}

//https://pt.stackoverflow.com/q/99562/101
