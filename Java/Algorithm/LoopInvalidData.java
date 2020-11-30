
import java.util.Scanner;

public class Main {
    public static void main (String[] args) {
    	Scanner sc = new Scanner(System.in);
        int notaAluno [] = new int[5];
        for (int i = 0; i < notaAluno.length; i++) {
            var nota = sc.nextInt();;
            if (nota < 0 || nota > 100) {
                System.out.println("Nota inválida, digite novamente:");
                i--;
                continue;
            }
            notaAluno[i] = nota;
        }
        for (int i = 0; i < notaAluno.length; i++) System.out.println("Nota do aluno " + i + ":" + notaAluno[i]);
    }
}

//https://pt.stackoverflow.com/q/484418/101
