import java.util.Scanner;

public class Main{
	public static void main(String[] args) {
		int valor[] = new int[5];
		Scanner in = new Scanner(System.in);
		for (int i = 0; i < valor.length; i++) {
			valor[i] = in.nextInt();
			if (valor[i] >= 100) valor[i] = valor[i] = in.nextInt();
		}
		for (int i = 0; i < valor.length &&valor[i] != 42; i++) System.out.println(valor[i]);
	}
}

//https://pt.stackoverflow.com/q/89875/101
