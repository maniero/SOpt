using static System.Console;
using System.Threading.Tasks;
					
public class Program {
    public static int Pontu1 { get; set; }

    public static int IncrementaPontos(int pontu1) {
        Pontu1++;
        return pontu1;
    }

    public static void RespostaCerta() {
        WriteLine("Resposta certa");
        IncrementaPontos(Pontu1);
        Task.Delay(2000);
//        Console.Clear();
    }

    public static void RespostaErrada() {
        WriteLine("Resposta errada");
        Clear();
    }

    public static void Resetar() {
        WriteLine("Sua pontuação atual é: " + Pontu1);
        WriteLine("Deseja reiniciar sua pontuação?      S  / N");
        string r = ReadLine();
        if (r == "S")  {
            Pontu1 = 0;
            WriteLine("Pontuação reiniciada.");
		} else WriteLine("Pontuação mantida.");
        WriteLine("Sua pontuação atual é: " + Pontu1);
        WriteLine("Pressione ENTER para voltar ao menu...");
    }

    public static void QuizIncio() {
        WriteLine("Escolha um assunto!");
        WriteLine("[ 1 ] teste");
        WriteLine("[ 2 ] teste2");
        WriteLine("-------------------------------------");
        Write("Digite uma opção: ");
        if (!int.TryParse(ReadLine(), out int opcao)) return;
        switch (opcao) {
            case 1:
                Class1.Teste();
                break;
            case 2:
                break;
        }
 //       Console.Clear();
    }
	
    public static void Main(string[] args) {
        int opcao;
        do
        {
            WriteLine("[ 1 ] Iniciar");
            WriteLine("[ 2 ] Ver Pontuação");
            WriteLine("[ 3 ] Resetar Pontuação");
            WriteLine("[ 0 ] Sair do Programa");
            WriteLine("-------------------------------------");
            Write("Digite uma opção: ");
            if (!int.TryParse(ReadLine(), out opcao)) continue;
            switch (opcao) {
                case 1:
 //                   Console.Clear();
                    QuizIncio();
                    break;
                case 2:
                    WriteLine("Sua pontuação é: " + Pontu1);
                    WriteLine("Pressione ENTER para continuar....");
                    break;
                case 3:
//                    Clear();
                    Resetar();
                    break;
                case 0:
                    break;
            }
//            Console.Clear();
        } while (opcao != 0); 
    }
}

class Class1 : Program {
    public static void Teste() {
        WriteLine("Quanto é 2 + 2?");
        WriteLine("a) 4");
        WriteLine("b) 3");
        string r1 = ReadLine();
        if (r1 == "a") RespostaCerta();
        else RespostaErrada();
    }
}

//https://pt.stackoverflow.com/q/189460/101
