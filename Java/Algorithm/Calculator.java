import java.io.*;
import java.net.*;
import java.util.Scanner;

class Argumentos {
    public static void main(String[] args) {
        float resultado = 0;
        System.out.println("Insira um valor: ");
        Scanner scanner1 = new Scanner(System.in);
        float num1 = scanner1.nextFloat();
        System.out.println("Insira outro valor: ");
        Scanner scanner2 = new Scanner(System.in);
        float num2 = scanner2.nextFloat();
        System.out.println("Insira a operação (+, -, / ou *): ");
        Scanner c = new Scanner(System.in);
        char operacao = c.next().charAt(0);
        do {
            if (operacao == '*') {
                resultado = num1 * num2;
            } else if (operacao == '/') {
                resultado = num1 / num2;
            } else if (operacao == '+') {
                resultado = num1 + num2;
            } else if (operacao == '-') {
                resultado = num1 - num2;
            }
            System.out.println("Insira a operação (+, -, / ou *): ");
            operacao = c.next().charAt(0);
            System.out.println("Resultado da conta: " + resultado);
        } while (operacao != '*' && operacao != '/' && operacao != '-' && operacao != '+');
        System.out.println("Resultado da conta: " + resultado);
    }
}

//https://pt.stackoverflow.com/q/149833/101
