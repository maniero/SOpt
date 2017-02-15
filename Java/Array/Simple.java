import java.util.*;

class HelloWorld {
	public static void main (String[] args)	{
		String[] nomes = new String[3];
		Scanner scanner = new Scanner(System.in);
		for (int i = 0; i < 3; i++) {
		    System.out.print("Nome: ");
		    nomes[i] = scanner.nextLine();
		    System.out.println();
		}
		for (int i = 0; i < 3; i++) {
		    System.out.println("Nome: " + nomes[i]);
		}
	}
}

//http://pt.stackoverflow.com/q/184408/101
