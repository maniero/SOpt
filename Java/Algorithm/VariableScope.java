import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner teclado = new Scanner(System.in);
        int soma = 0;
        int valor = 0;
        do {
            System.out.print("Digite um número (0 para sair):");
            valor = teclado.nextInt();
            soma += valor;
        } while (valor != 0);
        System.out.printf("\n A soma dos números digitados é: %d\n", soma);
    }
}

//https://pt.stackoverflow.com/q/412663/101
