import java.util.*;

class Ideone {
	public static void main (String[] args)	{
		List<String> list = new ArrayList<String>();
		list.add("a");
		list.add("b");
		list.add("c");
		for (int i = 0; i < list.size(); i++) {
		    System.out.println("Passo " + i + " Antes => " + list.get(i));
		    if (list.get(i) == "b") list.remove(list.get(i));
		    System.out.println("Passo " + i + " Depois => " + list.get(i));
		}
	}
}

//https://pt.stackoverflow.com/q/341518/101
