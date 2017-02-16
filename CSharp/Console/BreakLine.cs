using static System.Console;

public class Program {
    public static void Main() {
        var A1 = ReadLine();
        var A2 = ReadLine();
        var A3 = ReadLine();
        var A4 = ReadLine();
        var A5 = ReadLine();
        var A6 = ReadLine();
        var A7 = ReadLine();
        var A8 = ReadLine();
        WriteLine($"Segunda: {A1}, {A8}, {A4}, {3},");
        WriteLine($"Terça: {A2}, {A7}, {A3}, {A6},");
        
        WriteLine();

        Write($"Segunda: {A1}, {A8}, {A4}, {3},");
        WriteLine();
        Write($"Terça: {A2}, {A7}, {A3}, {A6},");
		WriteLine();

        WriteLine();

        Write($"Segunda: {A1}, {A8}, {A4}, {3},\nTerça: {A2}, {A7}, {A3}, {A6}\n");

        WriteLine();

        Write($@"Segunda: {A1}, {A8}, {A4}, {3},
Terça: {A2}, {A7}, {A3}, {A6}\n");

    }
}

//http://pt.stackoverflow.com/q/184489/101
