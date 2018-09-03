using static System.Console;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        Write("Quantos funcionários serão cadastrados? ");
        if (!int.TryParse(ReadLine(), out var quantidade)) return;
        var lista = new List<Funcionario>();
        for (int i = 0; i < quantidade; i++) {
            WriteLine($"Dados do {(i + 1)}º funcionário: ");
            Write("CPF: ");
            if (!int.TryParse(ReadLine(), out var cpf)) return;
            Write("Nome: ");
            var nome = ReadLine();
            Write("Salário: ");
            if (!double.TryParse(ReadLine(), out var salario)) return;
            lista.Add(new Funcionario(cpf, nome, salario));
            WriteLine();
        }
        foreach (var item in lista) WriteLine($"CPF: {item.Cpf} - Nome: {item.Nome} - Salário: {item.Salario}");
    }
}

public class Funcionario {
	public int Cpf;
	public string Nome;
	public double Salario { get; private set; }
	public Funcionario (int cpf, string nome, double salario) {
		Cpf = cpf;
		Nome = nome;
		Salario = salario;
	}
}

//https://pt.stackoverflow.com/q/326941/101
