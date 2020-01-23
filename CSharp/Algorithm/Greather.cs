using static System.Console;

public static class Program {
    public static void Main(string[] args) {
        Write("Digite um número: ");
        if (!int.TryParse(ReadLine(), out var a)) {
            Write("Deu erro");
            return;
        }
        Write("Digite outro número: ");
        if (!int.TryParse(ReadLine(), out var b)) {
            Write("Deu erro");
            return;
        }
        if (a > b) Write($"{a} é maior que {b}.");
        else if (b > a) Write($"{b} é maior que {a}.");
        else Write("Os dois números são iguais");
    }
}

//https://pt.stackoverflow.com/a/136298/101
