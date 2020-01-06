using static System.Console;
using System;
					
public class Program {
	public static void Main() {
		DateTime dt = DateTime.Now;
		DateTime? dtn = null;
		WriteLine(dt);
		WriteLine(dtn);
		dtn = dt;
		WriteLine(dtn);
		dt = dtn ?? default(DateTime); //daria erro de compilação se não fizesse esta verificação
		WriteLine(dtn);
		dt = dtn.GetValueOrDefault(); //também pode usar isto
		WriteLine(dtn);
		dt = dtn.GetValueOrDefault(); //também pode usar isto
		WriteLine(dtn);
		if (dtn != null) WriteLine("tem valor");
		if (dtn.HasValue) WriteLine("tem valor");
	}
}

//https://pt.stackoverflow.com/q/125827/101
