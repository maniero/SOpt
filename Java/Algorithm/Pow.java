import java.util.Scanner;

class Main {
	public static void main (String[] args) {
	    Scanner input = new Scanner(System.in);
	    System.out.println("Digite o valor da base:");
	    int base = input.nextInt();
	    System.out.println("Digite o valor do expoente:");
	    int expoente = input.nextInt();
	    int contador = 0;
	    int potencia = 1;
	    while (contador != expoente) {
	        potencia *= base;
	        contador++;
	    }
	    System.out.printf("A potencia de int %d como base e int %d como expoente eh: %d\n", base, expoente, potencia);
	    input.close();
	}
}

//https://pt.stackoverflow.com/q/463540/101
