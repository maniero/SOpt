using System;
					
public class Program
{
    public static int Pontu1 { get; set; }

    public static int pont(int pontu1)
    {
        Pontu1++;
        return pontu1;
    }

    public static void rcerta()
    {
        Console.WriteLine("Resposta certa");
        pont(Pontu1);
        System.Threading.Thread.Sleep(2000);
//        Console.Clear();
    }

    public static void rerrada()
    {
        Console.WriteLine("Resposta errada");
        Console.Clear();
    }

    public static void resetar()
    {
        string r;
        Console.WriteLine("Sua pontuação atual é: " + Pontu1);
        Console.WriteLine("Deseja reiniciar sua pontuação?      S  / N");
        r = Console.ReadLine();
        if (r == "S")
        {
            Pontu1 = 0;
            Console.WriteLine("Pontuação reiniciada.");
            Console.WriteLine("Sua pontuação atual é: " + Pontu1);
            Console.WriteLine("Pressione ENTER para voltar ao menu...");
        }
        else
        {
            Console.WriteLine("Pontuação mantida.");
            Console.WriteLine("Sua pontuação atual é: " + Pontu1);
            Console.WriteLine("Pressione ENTER para voltar ao menu...");
        }
    }

    public static void QuizIncio()
    {
        int opcao;
        Console.WriteLine("Escolha um assunto!");
        Console.WriteLine("[ 1 ] teste");
        Console.WriteLine("[ 2 ] teste2");
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite uma opção: ");
        opcao = Int32.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                Class1.teste();
                break;
            case 2:
                break;
            default:
                break;
        }
 //       Console.Clear();
    }
    public static void Main(string[] args)
    {
        int opcao;
        do
        {
            Console.WriteLine("[ 1 ] Iniciar");
            Console.WriteLine("[ 2 ] Ver Pontuação");
            Console.WriteLine("[ 3 ] Resetar Pontuação");
            Console.WriteLine("[ 0 ] Sair do Programa");
            Console.WriteLine("-------------------------------------");
            Console.Write("Digite uma opção: ");
            opcao = Int32.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
 //                   Console.Clear();
                    QuizIncio();
                    break;
                case 2:
                    Console.WriteLine("Sua pontuação é: " + Pontu1);
                    Console.WriteLine("Pressione ENTER para continuar....");
                    break;
                case 3:
                    Console.Clear();
                    resetar();
                    break;
                case 0:
                    break;
            }
//            Console.Clear();
        }
        while (opcao != 0); 
    }




}

class Class1 : Program
{
    public static void teste()
    {
        string r1, r2, r3, r4, r5;
        Console.WriteLine("Quanto é 2 + 2?");
        Console.WriteLine("a) 4");
        Console.WriteLine("b) 3");
        r1 = Console.ReadLine();
        if (r1 == "a")
        {
            rcerta();
        }
        else
        {
            rerrada();
        }
    }
}

//http://pt.stackoverflow.com/q/189460/101
