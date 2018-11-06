import java.util.*;

class Ideone {
	public static void main (String[] args)	{
		List<String> list = new ArrayList<String>();
		list.add("a");
		list.add("b");
		list.add("c");
		Iterator<String> i = list.iterator();
		while (i.hasNext()) {
		    String nome = i.next();
            System.out.println("Antes => " + nome);
		    if (nome == "b") i.remove();
		    System.out.println("Depois => " + nome);
		}
	}
}

//https://pt.stackoverflow.com/q/341518/101
