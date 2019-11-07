using static System.Console;

public class Cliente {
    public string Nome { get; set; }
    public decimal Saldo { get; set; }
    public Caixa caixa;
    public string Imprimir() => $"Cliente: {Nome} | Saldo: {Saldo}";
	public Cliente(string nome) => Nome = nome;
}

public class Caixa {
    public int Codigo { get; set; }
    public string NomeOperador { get; set; }
    public Cliente cliente;
    public string Imprimir() => $"Código {Codigo} | Operador: {NomeOperador}";
	public Caixa(int codigo) => Codigo = codigo;
}

public class AppCaixa {
    static int Main(string[] args) {
        Write("Digite o nome do cliente: ");
        var nome = ReadLine();
        var cliente = new Cliente(nome);
        Write("Digite o nome do saldo do cliente: ");
        if (!decimal.TryParse(ReadLine(), out decimal digiteSaldo)) return 1;
        cliente.Saldo = digiteSaldo;
        Write("Digite o código do caixa: ");
        if (!int.TryParse(ReadLine(), out int digiteCodigo)) return 1;
        var codigo = digiteCodigo;
        var caixa = new Caixa(codigo);
        Write("Digite o nome do caixa: ");
        caixa.NomeOperador = ReadLine();
        cliente.caixa = caixa;
        caixa.cliente = cliente;
        WriteLine($"{caixa.Imprimir()}");
        WriteLine($"{cliente.Imprimir()}");
        return 0;
    }
}

//https://pt.stackoverflow.com/q/419385/101
