import java.util.Scanner;

class Exercicio2 {
    public static void main(String[] args) {
        Scanner valor = new Scanner(System.in);
        System.out.println("Digite o primeiro número: ");
        int A = valor.nextInt();
        System.out.println("Digite o segundo número: ");
        int B = valor.nextInt();
        System.out.println("Digite o terceiro número: ");
        int C = valor.nextInt();
        if (A == B || B == C || A== C) {
	        System.out.println("Existem números repetidos!");
	    } 
        if (A > B && A > C) { //A é o maior
            if (B > C) System.out.println(A + " -> " + B + " -> " + C);
            else System.out.println(A + " -> " + C + " -> " + B);
        }
        if (B > A && B > C) { //B é o maior
            if (A > C) System.out.println(B + " -> " + A + " -> " + C);
            else System.out.println(B + " -> " + C + " -> " + A);
        }
        if (C > A && C > B) { //C é o maior
            if (A > B) System.out.println(C + " -> " + A + " -> " + B);
            else System.out.println(C + " -> " + B + " -> " + A);
        }
    } 
}

//https://pt.stackoverflow.com/q/385038/101
