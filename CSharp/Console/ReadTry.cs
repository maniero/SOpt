using static System.Console;

public static class Program {
    public static void Main(string[] args) {
        WriteLine("Qual é a sua idade?");
		if (int.TryParse(ReadLine(), out var age)) {
            if (age < 16) WriteLine("Não é permitido entrada de menores de 16.");
            else WriteLine("Bem-Vindo!");
		} else WriteLine("O valor informado é inválido");

    }
}

//https://pt.stackoverflow.com/q/281432/101
