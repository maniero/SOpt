import java.util.Random;

class Ideone {
	public static void main(String[] args) {
	    String letras = "ABC";  
	    Random gerador = new Random();  
	    System.out.println(letras.charAt(gerador.nextInt(letras.length())));
	}
}

//https://pt.stackoverflow.com/q/39951/101
