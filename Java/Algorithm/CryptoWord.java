import java.util.Scanner;

class ExerciciosClass01h {
    public static String lerpalavra(int ini, int fim) {
        Scanner ler = new Scanner(System.in);
        System.out.println("Digite uma palavra:");
        String palavra;
        do {
            System.out.print("-> ");
            palavra = ler.nextLine();
        } while (palavra.length() < ini || palavra.length() > fim);
        return palavra;
    }
    public static String criptografar(String palavra) {
    	String invertida = "";
        for (int ctcar = palavra.length() - 1; ctcar >= 0; ctcar--) {
             invertida += trocaVogal(palavra.charAt(ctcar));
        }
        return invertida;
    }
    public static char trocaVogal(char letra) {
    	String vogais = "AaEeIiOoUuAa";
    	int posicao = vogais.indexOf(letra);
    	if (posicao == -1) {
    		return letra;
    	}
    	return vogais.charAt(posicao + 2);
    }
    public static void main(String[] args) {
        System.out.println(criptografar(lerpalavra(1, 20)));
    }
}

//https://pt.stackoverflow.com/q/131177/101
