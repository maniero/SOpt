import java.util.Scanner;
import java.util.ArrayList;

class Program {
    public static void main(String[] args) {
        ArrayList<Float> valores= new ArrayList<Float>();
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
            valores.add(valor);
            contador++;
            acumulador += valor;
            System.out.println("Deseja inserir outro valor S/N? ");
            if (!scanner.next().equals("S")) break;
        }
        for (int i = 0; i < valores.size(); i++) System.out.println("Nota " + (i + 1) + ": " + valores.get(i));
        System.out.println("Média: "+ acumulador / contador);
    }
}

//https://pt.stackoverflow.com/q/153379/101
