import java.util.*;

class Main {
	public static HashMap<String, String> lista = new HashMap<>();
	
	private static void Put(String teste, String outra) {
	    for (int i = 0; i < 100000; i++) if (lista.containsKey("antonio")) lista.put(teste, outra);
	}
	
	private static void Replace(String teste, String outra) {
	    for (int i = 0; i < 100000; i++) lista.replace(teste, outra);
	}
	
	public static void main(String[] args) {
	    long inicio = System.currentTimeMillis();
	    Put("antonio", "antonio");
	    System.out.println("Put: " + (System.currentTimeMillis() - inicio)  + " ms");
	    inicio = System.currentTimeMillis();
	    Replace("antonio", "antonio");
	    System.out.println("Replace: " + (System.currentTimeMillis() - inicio) + " ms");
	}
}

//https://pt.stackoverflow.com/q/319076/101
