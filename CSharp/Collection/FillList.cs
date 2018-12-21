using static System.Console;
using System.Collections.Generic;
using System.Linq;
					
public class Cliente {
	public int Cpf {get; set; }
	public string Nome {get; set; }
	public int Tel {get; set; }
	public string End {get; set; }
}				

public class Program {
	static List<Cliente> ClienteList = new List<Cliente>();
				
    public static void Main(string[] args) {
        var op = -1;
        while (op != 0) {		
			WriteLine("Digite seu CPF (0 p/ sair)");
			if (!int.TryParse(ReadLine(), out var consulta)) continue;
			if (consulta == 0) {
				return;
			}
			var cliente = ClienteList.Where(c => c.Cpf == consulta).FirstOrDefault();
			if (cliente != null) {
				WriteLine("Nome: " + cliente.Nome);
				WriteLine("Telefone: " + cliente.Tel);
				WriteLine("Endereco: " + cliente.End);
				WriteLine("[1 - Editar] [2 - Remover] [3 - Nova consulta] [0 - Sair]");
			    if (!int.TryParse(ReadLine(), out op)) continue;
				switch (op) {
                case 1:
                    CadastroCliente(cliente);
                    break;
                case 2:
					ClienteList.Remove(cliente);
					WriteLine("Cadastro removido com sucesso. ");
                    break;
				}
			} else {
				var novo = new Cliente() { Cpf = consulta };
				CadastroCliente(novo);
				ClienteList.Add(novo);
			}
		}
    }
    public static void CadastroCliente(Cliente cliente) {
        WriteLine("Digite o nome: ");
        cliente.Nome = ReadLine();
        WriteLine("Digite o telefone: ");
        cliente.Tel = int.Parse(ReadLine());
        WriteLine("Digite o endereco: ");
        cliente.End = ReadLine();
    }
}

//https://pt.stackoverflow.com/q/43974/101
