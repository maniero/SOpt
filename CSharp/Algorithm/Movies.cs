using static System.Console;

public class Program {
    public static void Main() { 
        DadosFilme[] dados = new DadosFilme[6];
        for (int i = 0; i < 5; i++) {
            dados[i] = new DadosFilme();
            Clear();
            WriteLine("Digite as informações do filme: ");
            Write("Nome do filme.....: ");
            dados[i].NomeFilme = ReadLine();
            Write("Duração do filme..: ");
            if (!int.TryParse(ReadLine(), out dados[i].Duracao)) return;
            Write("Nome do Diretor...: ");
            dados[i].NomeDiretor = ReadLine();
            Write("Categoria do filme: ");
            dados[i].Categoria = ReadLine();
            Write("Ano de lançamento.: ");
            if (!int.TryParse(ReadLine(), out dados[i].Ano)) return;
        }
        Clear();
        WriteLine("Digite a sua categoria de filme preferida: ");
        var categoria = ReadLine();
        Clear();
        foreach (var item in dados) {
            WriteLine($"Nome do filme............: {item.NomeFilme}");
            WriteLine($"Duração do filme.........: {item.Duracao}");
            WriteLine($"Nome do Diretor..........: {item.NomeDiretor}");
            WriteLine($"Categoria do Filme.......: {item.Categoria}");
            WriteLine($"Anop de Lançamento.......: {item.Ano}\n\n");
        }
        WriteLine($"Filmes que pertencem a categoria {categoria}: ");
        dados[5] = new DadosFilme();
        dados[5].Categoria = categoria; //isto não faz sentido
        foreach (var item in dados) if (item == dados[5]) WriteLine(item.NomeFilme);
    }
}

public class DadosFilme {
    public string NomeFilme;
    public int Duracao;
    public string NomeDiretor;
    public string Categoria;
    public int Ano;
}

//https://pt.stackoverflow.com/q/327935/101
