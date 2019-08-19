import java.util.*;

class Main {
	public static void main (String[] args) {
		System.out.println(aleatoriar(1500, 5000));
	}
	public static int aleatoriar(int minimo, int maximo) {
	    Calendar lCDateTime = Calendar.getInstance();
        return (int)(lCDateTime.getTimeInMillis() % (maximo - minimo + 1) + minimo);
	}
}

//https://pt.stackoverflow.com/q/54358/101
