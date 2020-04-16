import java.util.*;

class Main {
	public static void main(String[] args) {
		Scanner scan = new Scanner (System.in);
		System.out.println("Sistema Harmônico");
		System.out.println("Digite em até que número a série irá");
		int numero = scan.nextInt();
		double numHarmonico = 0;
		for (int i = 1; i <= numero; i++) numHarmonico += 1.0 / i;
		System.out.printf("%.2f", numHarmonico);
		scan.close();
	}
}

//https://pt.stackoverflow.com/q/446540/101
