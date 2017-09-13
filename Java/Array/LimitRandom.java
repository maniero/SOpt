import java.util.Scanner;
import java.util.Random;

public class Sorteio {
    public static void main(String []args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Informe o numero de pessoas no sorteio: ");
        int n = sc.nextInt();
        String pessoa [] = new String [n];
        for (int i = 0; i < n; i++) {
            System.out.println("Informe a " + (i + 1) + "a pessoa: ");
            pessoa[i] = sc.nextLine();
            if (i == 0) sc.nextLine();
        }
        Random rd = new Random(n);
        System.out.println("O vencedor do sorteio e: " + pessoa[rd.nextInt(n)]);
    }
}

//https://pt.stackoverflow.com/q/237073/101
