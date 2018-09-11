using static System.Console;

namespace Exercício6Testes {
    public class Program {
        public static void Main() {
            int[] r = new int[10];
            int[] s = new int[10];
            int[] v = new int[20];
            WriteLine("Este programa lê dois vetores e mostra a união dos dois sem valores repetidos");
            WriteLine("Digite os 10 valores do vetor R:\n");
            var j = 0;
            for (var i = 0; i < 10; i++) {
                Write($"Digite o valor de  R{i + 1}: ");
                if (!int.TryParse(ReadLine(), out r[i])) {
                    i--;
                    continue;
                }
                if (!EhRepetido(v, r[i], j)) v[j++] = r[i];
            }
            WriteLine("Agora digite os valores do vetor S: ");
            for (var i = 0; i < 10; i++) {
                Write($"Digite o valor de S{i + 1}: ");
                if (!int.TryParse(ReadLine(), out s[i])) {
                    i--;
                    continue;
                }
                if (!EhRepetido(v, s[i], j)) v[j++] = s[i];	
            }
            WriteLine("União dos dois vetores: ");
            for (int i = 0; i < j; i++) Write($"{v[i]}\t");
        }
        public static bool EhRepetido(int[] vetor, int item, int posicao) {
            for (int i = 0; i < posicao; i++) if (vetor[i] == item) return true;
            return false;
        }
    }
}

//https://pt.stackoverflow.com/q/328075/101
