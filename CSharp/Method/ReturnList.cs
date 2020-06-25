using static System.Console;
using System.Collections.Generic;

public class Program {
	public static void Main() => ListMethod.GenerateList(5);
}

public static class ListMethod {
	public static List<int> GenerateList(int length) {
        var numbers = new List<int>(length);
        for (int c = 0; c < length; c++) {
            WriteLine($"Qual é o {c + 1}º número da lista?");
			if (!int.TryParse(ReadLine(), out var number)) {
				WriteLine("Valor digitado errado, digite novamente");
				c--;
				continue;
			}
            numbers.Add(number);
        }
        return numbers;
    }
}

//https://pt.stackoverflow.com/q/252328/101
