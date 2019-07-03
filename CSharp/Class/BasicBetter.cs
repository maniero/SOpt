using static System.Console;

public class Program {
    public static void Main(string[] args) {
         var cliente = new Cliente("João", "20", "Rua Torta", "Centro");
         WriteLine(cliente.Endereco.Rua);

    }
}

class Cliente {
    public string Nome {get; set;}
    public string Idade {get; set;}
    public Endereco Endereco {get; set;}

    public Cliente(string nome, string idade, string rua, string bairro) {
        Nome = nome;
        Idade = idade;
        Endereco = new Endereco(rua, bairro);
    }
}

class Endereco {
    public string Rua {get; set;}
    public string Bairro {get; set;}
    //Note que não é preciso criar um construtor Endereco() já que ele não fará nada extra
    //O compilador criará um para você
    public Endereco(string rua, string bairro) {
        Rua = rua;
        Bairro = bairro;
    }
}

//https://pt.stackoverflow.com/q/49647/101
