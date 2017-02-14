import java.util.*;
import java.lang.Math;

class HelloWorld {
	public static void main (String[] args) {
		 ArrayList<Integer> lista = new ArrayList<>();
		 for (int i = 0; i < 50; i++) {
		 	lista.add(i);
		 }
		 lista = seleciona(lista);
		 for (int i = 0; i < 50; i++) {
		 	System.out.println(lista.get(i));
		 }
	}
	public static ArrayList<Integer> seleciona(ArrayList<Integer> arraylist) {
		Random rnd = new Random();
        ArrayList<Integer> temp = new ArrayList<>(arraylist.size());
        for (int i = 0; i < arraylist.size(); i++) {
        	temp.add(arraylist.get(rnd.nextInt(arraylist.size())));
        }
        return temp;
    }
}

//http://pt.stackoverflow.com/q/183808/101
