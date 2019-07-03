using static System.Console;

public class Program {
    public static void Main(string[] args) {
        Cliente cliente = new Cliente();
        cliente.endereco.rua = "guaranesia";
        WriteLine(cliente.endereco.rua);
    }
}

class Cliente {
    public string name{get; set;}
    public string idade { get; set; }
    public Endereco endereco = new Endereco();
}

class Endereco {
    public string rua { get; set; }
    public string bairro { get; set; }
}

//https://pt.stackoverflow.com/q/49647/101
