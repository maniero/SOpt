import java.util.Scanner;

class MenorValorSequencia {
    public static void main(String args[]) {
	    Scanner sc = new Scanner(System.in);
	    int[] variavel = new int[10];
	    for (int i = 0; i <= 9; i++) variavel[i] = sc.nextInt();
	    int menorValor = Integer.MAX_VALUE;
	    for (int i = 0; i <= 9; i++) if (variavel[i] < menorValor) menorValor = variavel[i];
        System.out.println(menorValor);
    }
}

//https://pt.stackoverflow.com/q/141056/101
