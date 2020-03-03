import java.util.*;
import java.lang.*;

class Main {
	public static void main (String[] args) throws java.lang.Exception {
		ArrayList<Integer> x = new ArrayList<Integer>();
		x.add(1); x.add(2); x.add(3); x.add(4); x.add(5);
		for (int i = 0; i < x.size(); i++) {
			if (i % 2 == 0) { //retira os elementos pares
				x.remove(i);
			}
			System.out.println("Tamanho atual = " + x.size() + ", i = " + i); //só para ajudar visualizar
		}
		System.out.println("---");
		for (int i = 0; i < x.size(); i++) System.out.println(x.get(i));
		System.out.println("---------------------");
		x = new ArrayList<Integer>();
		x.add(1); x.add(2); x.add(3); x.add(4); x.add(5);
		int tamanho = x.size();
		for (int i = 0; i < tamanho; i++) {
			if (i % 2 == 0) x.remove(i);
			System.out.println("Tamanho atual = " + x.size() + ", i = " + i); //só para ajudar visualizar
		}
		System.out.println("---");
		for (int i = 0; i < x.size(); i++) System.out.println(x.get(i));
	}
}

//https://pt.stackoverflow.com/q/152521/101
