import java.util.*;

class Main {
	public static void main (String[] args) {
		System.out.println(aleatoriar(1500, 5000));
	}
	public static int aleatoriar(int minimo, int maximo) {
	    Random random = new Random();
	    return random.nextInt((maximo - minimo) + 1) + minimo;
	}
}

//https://pt.stackoverflow.com/q/54358/101
