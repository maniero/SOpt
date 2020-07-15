import java.util.*;

class Main {
	public static void main(String[] args) {
	    Random rand = new Random();
	    int numero1 = rand.nextInt(2) + 1;
	    int numero2 = rand.nextInt(2) + 1;
	    int numero3 = rand.nextInt(2) + 1;
	    System.out.println("DOIS OU UM!");
	    System.out.print("Quantas partidas serão jogadas? ");
	    Scanner ler = new Scanner(System.in);
	    int numPartidas = ler.nextInt();
	    do {
	        System.out.println("Jogador 1: " + numero1);
	        System.out.println("Jogador 2: " + numero2);
	        System.out.println("Jogador 3: " + numero3);
	        System.out.println("------------");
	        if (numero1 != numero2 && numero1 != numero3) System.out.println("Jogador 1 venceu!");
	        else if (numero2 != numero1 && numero2 != numero3) System.out.println("Jogador 2 venceu!");
	        else if (numero3 != numero1 && numero3 != numero2) System.out.println("Jogador 3 venceu!");
	        else System.out.println("O jogo terminou empatado!");
	    } while (--numPartidas > 0);
	    System.out.println("Fim de Jogo!");
	}
}

//https://pt.stackoverflow.com/q/287395/101
