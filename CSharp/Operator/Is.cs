using static System.Console;
using System;

public class Program {
	public static void Main() {
		Teste(DateTime.Now);
		WriteLine();
		Teste("ok");
	}
	
	public static void Teste(object qualquerVariavel) {
		if(qualquerVariavel is DateTime x) {
			WriteLine($"A variável é DateTime e seu valor é {x.DayOfWeek}");
		}
		if(qualquerVariavel is DateTime) {
			WriteLine($"A variável é DateTime e seu valor é {((DateTime)qualquerVariavel).DayOfWeek}");
		}
		if(qualquerVariavel is DateTime) {
//			WriteLine($"A variável é DateTime e seu valor é {qualquerVariavel.DayOfWeek}"); //isto não compila
		}
		if(qualquerVariavel is "ok") {
			WriteLine($"A variável é string e vale ok");
		}
		switch (qualquerVariavel) {
			case null:
			    WriteLine("nulo");
			    break;
			case int i:
			    WriteLine(i);
			    break;
			case string s:
			    WriteLine(s);
			    break;
			case DateTime d:
			    WriteLine(d.DayOfWeek);
			    break;
		}
	}
}

//https://pt.stackoverflow.com/q/86493/101
