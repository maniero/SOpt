import java.util.*;
import java.util.Collections;

class HelloWorld {
	public static void main (String[] args) {
		 ArrayList<Integer> lista = new ArrayList<>();
		 for (int i = 0; i < 50; i++) {
		 	lista.add(i);
		 }
		 seleciona(lista);
		 for (int i = 0; i < 50; i++) {
		 	System.out.println(lista.get(i));
		 }
	}
	public static void seleciona(ArrayList<Integer> arraylist) {
        Collections.shuffle(arraylist);
    }
}

//http://pt.stackoverflow.com/q/183808/101
