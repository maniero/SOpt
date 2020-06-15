using static System.Console;

public class Program {
    public static void Main()   {
        int []vetor =  { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
        for (int i = 0; i < vetor.Length; i++ ) vetor[i] *= vetor[i];
        WriteLine($"{string.Join(", ", vetor)}.");
    }
}

//https://pt.stackoverflow.com/q/457059/101
