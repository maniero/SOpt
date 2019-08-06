import java.util.Scanner;

class Calculos extends Soma {
    public static void main(String[] args) {
        Calculos calculo = new Calculos();
        calculo.executa();
    }
    public void executa() {
        double v1, v2;
        Scanner insere = new Scanner(System.in);
        System.out.print("Digite o primeiro valor: ");
        v1 = insere.nextDouble();
        System.out.print("Digite o segundo valor: ");
        v2 = insere.nextDouble();
        setSoma(v1, v2);
        System.out.printf("O resultado da soma eh %.2f", getSoma());
    }
}

class Soma{
    private double total;
    public void setSoma(double s1, double s2) {
        total = s1+s2;
    }
    public double getSoma() {
        return total;
    }
}

//https://pt.stackoverflow.com/q/52471/101
