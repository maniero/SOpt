using static System.Console;

public class Program {
    public static void Main() {
        var x = new Exemplo();
        WriteLine(x.CalculaLucro());
    }
}

public class Exemplo {
    private decimal calculaDoacao(int iteracao, decimal valor) => 0.03M * calculaLucro(iteracao, valor);
    private decimal calculaLucro(int iteracao, decimal valor) {
        if (iteracao++ == 100) return valor;
        return valor - calculaDoacao(iteracao, valor);
    }
    public decimal CalculaDoacao() => calculaDoacao(0, 10000M);
    public decimal CalculaLucro() => calculaLucro(0, 10000M);
}

//https://pt.stackoverflow.com/q/348025/101
