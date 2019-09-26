import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Main {
    public static void main(String[] args) {
		List<Integer> lista = new ArrayList<>(60);
		for (int i = 1; i <= 60; i++) {
		    lista.add(i);
		}
		Collections.shuffle(lista);
		lista = lista.subList(0, 6);
		System.out.println(lista);
    }
}

//https://pt.stackoverflow.com/q/82819/101
