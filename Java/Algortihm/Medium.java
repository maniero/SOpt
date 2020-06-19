import java.util.*;

class Main {
    public static void main(String[] args) {
        Scanner ler = new Scanner(System.in);
        System.out.println("Informe a quantidade de numeros a serem listados.");
        int cp = ler.nextInt();
        int contPar = 0, contImpar = 0;
        int somaPar = 0, somaImpar = 0;
        for (int i = 0; i < cp; i++) {
            System.out.println("Digite o " + (i + 1) + "° numero: \n");
            int num = ler.nextInt();
            if (num % 3 == 0 && num % 5 == 0) {
                System.out.println("Este numero é divisivel por 3 e 5.");
            }
            if (num % 2 == 0) {
                System.out.println("Este numero é PAR.");
                contPar++;
                somaPar += num;
            } else {
                System.out.println("Este numero é IMPAR.");
                contImpar++;
                somaImpar += num;
            }
        }
        System.out.println("A media dos numeros PARES é : " + (float)somaPar / contPar);
        System.out.println("A media dos numeros IMPARES é : " + (float)somaImpar / contImpar);
    }
}

//https://pt.stackoverflow.com/q/242752/101
