import java.util.Scanner;

class exer {
    public static void main(String[] args){
        Scanner scn = new Scanner(System.in);
        double[] N = new double[10];
        for (int i = 0; i < N.length; i++) {
            System.out.println("Informe a Nota");
            N[i] = scn.nextDouble();
        }
    }
}

//https://pt.stackoverflow.com/a/236186/101
