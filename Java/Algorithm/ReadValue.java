import java.util.*;

class Program {
    public static void main(String[] args) {
        Scanner ler = new Scanner(System.in);
        for (int i = 0; i < 10; i++) {
            System.out.println("Digite o 1°numero" + i);
            int n = ler.nextInt();
            System.out.println("Multiplicação de 1 até 10" + n * i);
        }
    }  
}

//https://pt.stackoverflow.com/q/418510/101
