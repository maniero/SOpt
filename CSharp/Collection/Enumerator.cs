using System;
using System.Collections;

public class Program {
	static int[] array = new int[]{1, 2, 3, 4, 5 }; 
	public static void Main() {
		var o = Teste();
		if (o != null) {
			Console.WriteLine("Continuando...");
	    	while (o.MoveNext()) {
	        	Console.WriteLine(o.Current);
    		}	
		}
	}
	static IEnumerator Teste() {
    	IEnumerator o = array.GetEnumerator();
    	while (o.MoveNext()) {
        	Console.WriteLine(o.Current);
 			if ((int)o.Current > 2) {
				return o;
			}
   	}
		return null;
	}
}

//http://pt.stackoverflow.com/q/191222/101
