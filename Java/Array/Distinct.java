import java.util.*;
import java.util.stream.Collectors;

public class Program {
	public static void main (String[] args) {
		ArrayList<Integer> sequencia = new ArrayList<>();
		sequencia.add(2);
		sequencia.add(11);
		sequencia.add(12);
		sequencia.add(13);
		sequencia.add(14);
		sequencia.add(14);
		System.out.println(sequencia.stream().distinct().collect(Collectors.toList()).toString());
	}
}

//https://pt.stackoverflow.com/q/265506/101
