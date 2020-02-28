using System;
using static System.Console;
					
public class Program {
	public static void Main() {
		var aux = new DateTime(2016, 09, 02, 10, 0, 0);
		if (aux.Date == DateTime.Now.Date) WriteLine("Ok");
	}
}

//https://pt.stackoverflow.com/q/150667/101
