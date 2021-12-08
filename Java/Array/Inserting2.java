import java.util.Scanner;

class Program {
    public static void main(String[] args) {
        float acumulador = 0;
        int contador = 0;
        Scanner scanner = new Scanner(System.in);
        while (true) {
            System.out.println("Insira um valor: ");
            float valor = scanner.nextFloat();
            if (false) { //vai colocar a valisação aqui
                System.out.println("Valor inválido digite um válido");
                continue;
            }
            contador++;
            acumulador += valor;
            System.out.println("Deseja inserir outro valor S/N? ");
            if (!scanner.next().equals("S")) break;
        }
        System.out.println("Média: "+ acumulador / contador);
    }
}

//https://pt.stackoverflow.com/q/153379/101
