import java.util.*;

class Main {
	public static void main(String[] args) {
	    Scanner x = new Scanner(System.in);
	    System.out.println("inisira a quatidade de bimestres");
	    int bim = x.nextInt();
	    double soma= 0;
	    for (int i = 0; i < bim; i++) {
	        System.out.println("Insira a nota do " + (i + 1) + "º Bimestre");
	        soma += x.nextDouble();
	    }
	    System.out.println(soma / bim);
	}
}

//https://pt.stackoverflow.com/q/325788/101
