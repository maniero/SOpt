import java.util.*;

class Main {
	public static void main(String[] args) {
	    Scanner x = new Scanner(System.in);
	    System.out.println("Digite a quantidade de termos");
	    int n1 = 0, n2 = 1;
	    for (int qtd = x.nextInt(); qtd > 0; qtd--) {
	    	System.out.print(n1 + " ");
	   		int n3 = n1 + n2;
	        n1 = n2;
	        n2 = n3;
	    }
	    System.out.println("Fim");
	}
}

//https://pt.stackoverflow.com/q/211562/101
