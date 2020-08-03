using static System.ConsoleColor;
using static System.Console;

namespace GambleGame {
    public class Program {
        public static void Main(string[] args) {
            ForegroundColor = Green;
            Intro();
        }

        public static void Intro() {
            //código do método estático intro
            WriteLine("---------------------------|||Seja bem vindo ao Gamble Game|||---------------------------");
            ResetColor();
            ForegroundColor = Yellow;
            WriteLine("- Intruções:");
            WriteLine("- Digite ''gamble'' para farmar 10 madeiras");
            WriteLine("- Para apostar ''X'' madeiras, digite ''apostar'' e o número de madeiras");
            WriteLine("- Você poderá apostar ''X'' madeiras para ganhar a mesma quantidade");
            WriteLine("- Porém, se você apostar ''X'' madeiras e perder, você perde essa mesma quantidade");
            WriteLine("- Tente ser o maior lenhador dentre seus amigos, boa sorte !");
            WriteLine("- Aperte Enter para começar !");
            ReadLine();
            Clear();
            Start(); //executa o método estático "start"
        }

        public static void Start() {
            ResetColor();
            ForegroundColor = Cyan;
            int madeiras = 0;
            WriteLine("Digite ''gamble'' para bater na árvore");
            WriteLine($"Você possui {madeiras} madeiras");
            while (true) {
                var gamble = ReadLine();
                if (gamble == "gamble") {
                    madeiras += 10;
                    Clear();
                } else {
                    Clear();
                    WriteLine("Digite ''gamble'' para bater na árvore");
                }
                if (gamble == $"gamble {madeiras}") {
                    madeiras += madeiras;
                }
                WriteLine($"Você possui {madeiras} madeiras");
            }
        }           
    }
}

//https://pt.stackoverflow.com/q/325272/101
