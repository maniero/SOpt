using System;

public class Program {
	public static void Main() {}
}

public class Pessoa {
	public string Nome { get; set; }
	public string Endereço { get; set; }
	public int Ano_nascimento { get; set; }
	public int Idade { get; set; }
	public string Telefone { get; set; }
	public Pessoa(string nome, string endereço, int ano_nascimento, string telefone) {
		Nome = nome;
		Endereço = endereço;
		Ano_nascimento = ano_nascimento;
		Telefone = telefone;
		Idade = DateTime.Now.Year - ano_nascimento;
	}
}

public class Fisica : Pessoa {	
	public string NmmCPF { get; private set; }
	public Fisica(string nome, string endereço, int ano_nascimento, string telefone, string nCPF)
		: base(nome, endereço, ano_nascimento, telefone) {
			this.NmmCPF = nCPF;
	}
}

public class Juridica : Pessoa {
	public string NumCnpj { get; private set; }
	public Juridica(string nome, string endereço, int ano_nascimento, string telefone, string nCNPJ)
		: base(nome, endereço, ano_nascimento, telefone) {
			NumCnpj = nCNPJ;
	}
}

//http://pt.stackoverflow.com/q/187631/101 
