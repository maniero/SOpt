using static System.Console;
using System.Dynamic;
using System.Collections.Generic;
					
public class Program {
	public static void Main() {
		dynamic obj = new ExpandoObject();
		obj.cor = "verde";
		obj.tamanho = 2000;
		WriteLine(obj.cor);
		WriteLine(obj.tamanho);
		var obj2 = (IDictionary<string,object>)obj;
		WriteLine(obj2["cor"]);
		WriteLine(obj2["tamanho"]);
	}
}

//https://pt.stackoverflow.com/q/92090/101
