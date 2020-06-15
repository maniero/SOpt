using static System.Console;

public class Program {
    public static void Main() {
        var veiculosArray = new Veiculo[10] ;
        veiculosArray[0] = new Veiculo("BMW", "DSR6646");
        WriteLine(veiculosArray[0]);
    }
}
class Veiculo {
    public string Modelo { get; set; } = "";
    public string Placa { get; set; } = "";
    public Veiculo(string modelo, string placa) {
        Modelo = modelo;
        Placa = placa;
    }
    public override string ToString() => Placa;
}

//https://pt.stackoverflow.com/q/457256/101
