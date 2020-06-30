import java.util.*;

class Main {
    public static long converte(String entrada) {
	    switch (entrada) {
	    case "um":
	        return 1;
	    case "dois":
	        return 2;
	    case "três":
	        return 3;
	    case "quatro":
	        return 4;
	    case "cinco":
	        return 5;
	    case "seis":
	        return 6;
	    case "sete":
	        return 7;
	    case "oito":
	        return 8;
	    case "nove":
	        return 9;
	    case "dez":
	        return 10;
	    default:
	        return -1;
	    }
	}
	public static void main(String[] args) {
	    Scanner key = new Scanner(System.in);
	    System.out.println("Inicialização...\nInstruções:\n1-Digite o nome de um número entre um~dez.\n2-O programa encerra ao digitar 'fim'.");
	    while (true) {
	        String entrada = key.nextLine();
	        if (entrada.equals("fim")) break;
	        long convertido = converte(entrada);
	        if (convertido == -1) {
	            System.out.println("Palavra inválida");
	            continue;
	        }
            System.out.println(convertido);
	    }
	    System.out.println("Fim!");
	    key.close();
	}
}

//https://pt.stackoverflow.com/q/256361/101
