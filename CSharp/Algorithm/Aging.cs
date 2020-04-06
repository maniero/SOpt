using static System.Console;

public class Idade {
    public static void Main() {
        WriteLine("Qual sua idade? ");
        if (!int.TryParse(ReadLine(), out var n1)) return; 
        else if (n1 < 10) WriteLine("Você é Criança");
        else if (n1 < 18) WriteLine("Você é Adolescente");
        else WriteLine("Você é Adulto");
    }
}

//https://pt.stackoverflow.com/q/444413/101
