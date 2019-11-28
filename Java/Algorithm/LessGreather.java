import java.util.Scanner;

class Ideone {
    public static void main(String[] args) {
	    Scanner sc = new Scanner(System.in);
	    System.out.println(" Tres números:");
	    int a = sc.nextInt();
	    int b = sc.nextInt();
	    int c = sc.nextInt();
	    int menor = a;
	    int maior = a;
	    if (b > maior) maior = b;
	    if (c > maior) maior = c;
	    if (b < menor) menor = b;
	    if (c < menor) menor = c;
	    System.out.println(" Maior: " + maior + " Menor: " + menor);
    }
}

//https://pt.stackoverflow.com/q/110753/101
