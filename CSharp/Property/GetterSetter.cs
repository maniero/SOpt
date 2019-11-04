using static System.Console;

public class Cliente {
    public string Nome { get; set; }
    public decimal Saldo { get; set; }
    public Caixa caixa;
    public string Imprimir() => $"Cliente: {Nome} | Saldo: {Saldo}";
}

public class Caixa {
    public int Codigo { get; set; }
    public string NomeOperador { get; set; }
    public Cliente cliente;
    public string Imprimir() => $"Código {Codigo} | Operador: {NomeOperador}";
}

public class AppCaixa {
    static int Main(string[] args)
    {
        var cliente = new Cliente();
        var caixa = new Caixa();
        Write("Digite o nome do cliente: ");
        cliente.Nome = ReadLine();
        Write("Digite o nome do saldo do cliente: ");
        if (!decimal.TryParse(ReadLine(), out decimal digitesaldo)) return 1;
        cliente.Saldo = digitesaldo;
        Write("Digite o código do caixa: ");
        if (!int.TryParse(ReadLine(), out int digitecodigo)) return 1;
        caixa.Codigo = digitecodigo;
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
