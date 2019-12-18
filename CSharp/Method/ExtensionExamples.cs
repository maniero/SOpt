using static System.Console;

public class HelloWorld {
    public static void Main() {
        Veiculo veiculoT = new Veiculo();
        WriteLine("veiculoT");
        veiculoT.diagnostico();
        veiculoT.liga();
        veiculoT.teste();
        veiculoT.compra();
        WriteLine("---------------");
        Veiculo carro = new Carro();
        WriteLine("carro");
        carro.diagnostico();
        carro.liga();
        carro.teste();
        carro.compra();
        WriteLine("---------------");
        Carro carro2 = new Carro();
        WriteLine("carro2");
        carro2.diagnostico();
        carro2.liga();
        carro2.buzina();
        carro2.teste();
        carro2.compra();
	}
}

interface IFuncionamento {
    void liga();
}

static class Funcionamento {
    public static void liga(this IFuncionamento func) => WriteLine("Ligou!");
    public static void buzina() => WriteLine("Buzinou!");
}

static class Testador {
    public static void teste(this IFuncionamento veiculo) {
        WriteLine("Vai testar");
        veiculo.liga();
    }
}

static class Financeiro {
    public static void compra(this Veiculo veiculo) {
        WriteLine("Comprou N: " + veiculo.id);
        veiculo.diagnostico();
        veiculo.liga();
    }
}

class Veiculo : IFuncionamento {
    public int id = 1;
    public void diagnostico() {
        Funcionamento.liga(this);
        Funcionamento.buzina();
        liga();
        WriteLine("Tudo ok!");
    }
	public virtual void liga() => Funcionamento.liga(this);
}

class Carro : Veiculo {
    public override void liga() => WriteLine("Vrom!");
    public void buzina() => WriteLine("bi bi!");
}

//https://pt.stackoverflow.com/q/121240/101
