using static System.Console;

public class Program {
     public static void Main(string[] args) {
         var client = new string[7, 7];
         InsertData<ClientHeader>(client);
         InsertData<ClientHeader>(client);
         AlunoLista(client);
     }
    static int getInsertIndex(string[,] matrix) {
        for (int j = 0; j < matrix.GetLength(0); j++) if (string.IsNullOrEmpty(matrix[j, 0])) return j;
        return -1;
    }
    private static void InsertData<T>(string[,] matrix) {
        int n = getInsertIndex(matrix), id = 1;
        matrix[n, 0] = (id++).ToString();
        int x = matrix.GetLength(1) - 1;
        matrix[n, x] = "true";
        for (var j = 1; j < matrix.GetLength(1); j++) {
            do {
                Write($"\nInsert {GetHeader<T>(j)}: ");
                matrix[n, j] = ReadLine();
            } while (string.IsNullOrEmpty(matrix[n, j]));
        }
    }

    private static string GetHeader<T>(int i) => System.Enum.GetName(typeof(T), i);

    static void AlunoLista(string[,] lista) {
        var linha = new string('-', 49);
        int[] tamanho = new int[] { 4, 10, 10, 20, 10, 10, 10 };
        for (int i = 0; i < lista.GetLength(1); i++) {
            WriteLine($"{linha}|");
            for (int j = 0; j < lista.GetLength(0); j++) {
                lista[j, i] = lista[j, i] ?? "";  // <===================== mudei aqui
                var espaço = new string (' ', tamanho[j] - lista[j, i].Length);
                Write($"{lista[j, i]}{espaço}|");
            }
            WriteLine();
        }
        WriteLine(linha);
    }
    enum ClientHeader { Id, Name, Surname, Addres, CodPostal, Telephone, Email, State };
}

//https://pt.stackoverflow.com/q/324023/101
