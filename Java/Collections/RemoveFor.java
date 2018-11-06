import java.util.*;

class Ideone {
	public static void main (String[] args)	{
		List<String> list = new ArrayList<String>();
		list.add("a");
		list.add("b");
		list.add("c");
		for (String i: list) {
            System.out.println("Antes => " + i);
		    if (i == "b") list.remove(i);
		    System.out.println("Depois => " + i);
		}
	}
}

//https://pt.stackoverflow.com/q/341518/101
