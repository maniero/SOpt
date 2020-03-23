import java.util.*;
import java.lang.*;
import java.io.*;

public class Principal {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        do {
            try {
                System.out.println("Entre com o primeiro numero: ");
                int num1 = sc.nextInt();
                System.out.println("Entre com o segundo numero: ");
                int num2 = sc.nextInt();
                menu(); //completa desnecessidade fazer isso
                int opc = sc.nextInt();
            } catch (InputMismatchException) {
                System.out.println("Você digitou algo irregular, vamos começar de novo");
                continue;
            }
            switch (opc) {
                case 0:
                    break;
                case 1:
                     System.out.println("\nResultado: " + new Calculadora(new Soma(), num1, num2));
                    break;
                case 2:
                    System.out.println("Resultado: " + new Calculadora(new Subtracao(), num1, num2) + "\n");
                    break;
                default:
                    System.out.println("Opcao Invalida.");
                    break;
            }
        } while (opc != 0);
    }

    static void menu() {
        System.out.println("\tEscolha uma Opcao ");
        System.out.println("0: Sair");
        System.out.println("1: Somar");
        System.out.println("2: Subtracao");
        System.out.print("Opcao: ");
    }
}

//https://pt.stackoverflow.com/q/165967/101
