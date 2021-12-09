import java.util.Scanner;

class Program {
    public static void main(String[] args) {
        float acumulador = 0;
        int contador = 0;
        Scanner scanner = new Scanner(System.in);
        while (true) {
            System.out.println("Insira um valor: ");
            String dado = scanner.nextLine();
            if (dado.equals("N")) break;
            try {
            	float valor = Float.parseFloat(dado);
                contador++;
                acumulador += valor;
            } catch (NumberFormatException ex) {
                System.out.println("Valor inválido digite um válido");
            }
         }
        System.out.println("Média: "+ acumulador / contador);
    }
}

//https://pt.stackoverflow.com/q/153379/101
