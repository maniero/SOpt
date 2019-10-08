using System;
					
public class Program {
	public static void Main() {
		try {
			throw new AccessViolationException ();
		} catch (AccessViolationException ex){
			Console.WriteLine(ex);
		}
	}
}

//https://pt.stackoverflow.com/q/87908/101
