using static System.Console;
					
public class Program {
    public static void Main() {
        var nomeCep = "JOSE - 09017092";
        var cep = nomeCep.Split('-')[1];
		WriteLine($"{cep.Substring(0, 6)}-{cep.Substring(6, 3)}");
    }
}

//https://pt.stackoverflow.com/q/146600/101
