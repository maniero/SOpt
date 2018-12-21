using System;
using System.Collections.Generic;
using System.Linq;
					
class Cliente {
	public int Cpf {get; set; }
	public string Nome {get; set; }
	public int Tel {get; set; }
	public string End {get; set; }
}				

public class Program {
	static List<Cliente> ClienteList = new List<Cliente>();
				
    public static void Main(string[] args) {
        int op = -1;

        while (op != 0) {

            Console.WriteLine("Digite 1 para cadastrar: ");
            Console.WriteLine("Digite 2 para consultar: ");
            Console.WriteLine("Digite 3 para remover cadastro");
            Console.WriteLine("Digite 4 para editar cadastro: ");
            Console.WriteLine("Digite 0 para sair: "); 

            op = int.Parse(Console.ReadLine());

            //aqui poderia ter um switch mas entendo que você ainda não aprendeu usá-lo ainda    
			if (op == 1) {
                CadastroCliente();
            } else if (op == 2) {
                ConsultaCadaCli();
            } else if (op == 3) {
                RemoverCadastro();
            } else if (op == 4) {
                EditarCliente();
            }

        }
    }
    public static void CadastroCliente()
    {
        Cliente cli = new Cliente();
        Console.WriteLine("Digite o CPF: ");
        cli.Cpf = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o nome: ");
        cli.Nome = Console.ReadLine();
        Console.WriteLine("Digite o telefone: ");
        cli.Tel = int.Parse(Console.ReadLine());
        Console.WriteLine("Digiete o endereco: ");
        cli.End = Console.ReadLine();

        ClienteList.Add(cli);

    }
    public static void ConsultaCadaCli() {
        Console.WriteLine("Digite seu CPF");
        int Consulta = int.Parse(Console.ReadLine());
        var cli = ClienteList.Where(c => c.Cpf.Equals(Consulta)).FirstOrDefault();

        if (cli != null) {
            Console.WriteLine("CPF: " + cli.Cpf);
            Console.WriteLine("Nome: " + cli.Nome);
            Console.WriteLine("Telefone: " + cli.Tel);
            Console.WriteLine("Endereco: " + cli.End);
        } else {
            Console.WriteLine("Cliente nao cadastrado");
        }
    }
    public static void RemoverCadastro() {
		Console.WriteLine("Digite seu CPF");
        int Consulta = int.Parse(Console.ReadLine());
        var cli = ClienteList.Where(c => c.Cpf.Equals(Consulta)).FirstOrDefault();

        if(cli != null) {
            ClienteList.Remove(cli);
            Console.WriteLine("Cadastro removido com sucesso. ");
        } else {
            Console.WriteLine("Cliente nao cadastrado");
        }
    }
	public static void EditarCliente() {
        Console.WriteLine("Digite seu CPF");
        int Consulta = int.Parse(Console.ReadLine());
		var cli = ClienteList.Where(c => c.Cpf.Equals(Consulta)).FirstOrDefault();
	
        if(cli != null) {
            Console.WriteLine("CPF: " + cli.Cpf);
            Console.WriteLine("Nome: " + cli.Nome);
            Console.WriteLine("Telefone: " + cli.Tel);
            Console.WriteLine("Endereco: " + cli.End);

			Console.WriteLine("Digite o nome: ");
			cli.Nome = Console.ReadLine();
			Console.WriteLine("Digite o telefone: ");
			cli.Tel = int.Parse(Console.ReadLine());
			Console.WriteLine("Digiete o endereco: ");
			cli.End = Console.ReadLine();
        } else {
            Console.WriteLine("Cliente nao cadastrado");
        }
    }
}

//https://pt.stackoverflow.com/q/43974/101
