import java.util.Formatter;
import java.util.Scanner;

public class PL7_ex6 {
    private static Scanner input = new Scanner(System.in);
    private static Formatter output = new Formatter(System.out);
    private static String[] visitantes = new String[100];
    private static int nElm = 0;

    public static void main(String[] args) {
        output.format("bem-vindo!");
        output.format("\n\nAqui pode:");
        int op;
        do {
            System.out.println("\n\n1 - Inserir um visitante"
                    + "\n2 - Listar todos os visitantes"
                    + "\n3 - Atualizar um nome dado"
                    + "\n4 - Eliminar um visitante dado"
                    + "\n5- Lisstar os nomes começados por uma dada letra"
                    + "\n6 - Listar nomes repetidos"
                    + "\n0 - para terminar o programa");
            op = input.nextInt();
            if (op < 0 || op > 6) {
                output.format("%sTem de introduzir uma opção válida!");
                continue;
            }
             switch (op) {
                case 1:
                    inserirVisitante();
                    System.out.println(visitantes[0]); //por que tem isso?
                    break;
                case 2:
                    listarVisitantes();
                    break;
                case 3:
                    break;
                default:
                    throw new AssertionError(); //não deveria fazer isso
            }
        } while (op != 0);
    }

    private static void inserirVisitante() {
        int pos = 0;
        int i = 0;
        if (nElm == visitantes.length) {
            output.format("Não há espaço disponível :(");
        } else {
            System.out.println("Introduza o nome do visitante");
            visitantes[nElm++] = input.nextLine().trim();
            //para testar
            System.out.println("\n" + nElm + "\n");
        }
        return;
    }

    private static void listarVisitantes() {
        if (nElm == 0) {
            //para testar
            System.out.println("\n" + nElm + "\n");
            output.format("Não há visitantes.");
        } else {
            for (int i = 0; i < nElm; i++) {
                output.format("%n%d", visitantes[i]);
            }
        }
    }
}

//https://pt.stackoverflow.com/q/252901/101
