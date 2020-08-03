import java.util.Scanner;

class Mult {
    public static void main(String args[]) {
        Scanner leitor = new Scanner(System.in);
        System.out.println("digite o primeiro numero");
        int numero1 = leitor.nextInt();
        System.out.println("digite o segundo numero");
        int numero2 = leitor.nextInt();
        System.out.println(numero2 % numero1 == 0 ? "É múltiplo" : "Não é múltiplo");
    }
}

//https://pt.stackoverflow.com/q/325025/101
