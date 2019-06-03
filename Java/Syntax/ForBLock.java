import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
	    int[] vet = new int[2];
		for (int i = 0; i < 2; i++) {
		    System.out.println("Digite um numero");
		    vet[i] = sc.nextInt();
		    
		}   
	 for (int i = 0; i < 2; i++) System.out.println(vet[i]);
	}     
}

//https://pt.stackoverflow.com/q/388491/101
