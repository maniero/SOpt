import java.util.*;

class Ideone {
	public static void main (String[] args)	{
		ArrayList<String> houses = new ArrayList<String>();
		houses.add("casa 1");
		houses.add("casa 2");
		houses.add("casa 1");
		houses.add("casa 3");
	    ArrayList<String> aux = new ArrayList<String>();
	    for (String item : houses) if (!aux.contains(item)) aux.add(item);
	    houses = aux;
	    for (String item : houses) System.out.println(item);
	}
}

//https://pt.stackoverflow.com/q/110791/101
