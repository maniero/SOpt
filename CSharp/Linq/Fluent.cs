using static System.Console;
using System.Collections.Generic;
using System.Linq;
					
namespace LinqConsulta {
	public class Program {
		public static void Main() {
			foreach (var item in new Empregados().Lista().OrderBy(e => e.Nome).ToList()) WriteLine(item.Nome);
		}
	}

    class Empregados : List<Empregado> { //não é recomendável fazer isto
        public Empregados Lista() {
            this.Add(new Empregado(1, "Maria", "maria@site.com.br", "11 1111 1111")); 
            this.Add(new Empregado(2, "João", "joao@site.com.br", "22 2222 2222"));
            this.Add(new Empregado(3, "José", "jose@site.com.br", "33 3333 3333")); 
            return this;
        }
    }
    class Empregado {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
		//tirei o construtor vazio que só permitia criar um obejto inválido
        public Empregado(int id, string nome, string email, string telefone) {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}

//https://pt.stackoverflow.com/q/133780/101
