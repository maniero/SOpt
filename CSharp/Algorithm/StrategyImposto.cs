using static System.Console;

public class Program {
    public static void Main() {
        var calc = new CalculaImposto(new CalculaImpostoSP());
        WriteLine("Imposto SP: " + calc.Calcula(1500M)); //aqui obviamente pegaria o valor do produto na classe específica
        calc.Strategy = new CalculaImpostoRJ();
        WriteLine("Imposto RJ: " + calc.Calcula(1500M));
    }
}

public interface ICalculaImposto {
    decimal Calcula(decimal baseCalculo);
}

public class CalculaImpostoSP : ICalculaImposto {
    public decimal Calcula(decimal baseCalculo) => baseCalculo * 0.18M;
}

public class CalculaImpostoRJ : ICalculaImposto {
    public decimal Calcula(decimal baseCalculo) => baseCalculo * 0.12M;
}

public class CalculaImposto {
    public ICalculaImposto Strategy { get; set; } //constuma-se considerar isto obrigatório para cumprimir o padrão
    public CalculaImposto(ICalculaImposto strategy) { Strategy = strategy; }
    public decimal Calcula(decimal baseCalculo) => Strategy.Calcula(baseCalculo);
}
//http://pt.stackoverflow.com/q/187908/101
