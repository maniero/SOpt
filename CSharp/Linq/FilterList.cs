using static System.Console;
using System.Collections.Generic;
using System.Linq;
					
public class Program {
	public static void Main() {
		var listaObj1 = new List<Objeto1>();
		var listaObj2 = new List<Objeto2>();
		var listaObj3 = new List<Objeto3>();
		listaObj3.Add(new Objeto3 { PropObj3 = 1 });
		listaObj3.Add(new Objeto3 { PropObj3 = 0 });
		listaObj2.Add(new Objeto2 { PropObj2 = listaObj3 });
		listaObj2.Add(new Objeto2 { PropObj2 = listaObj3 });
		listaObj1.Add(new Objeto1 { PropObj1 = listaObj2 });
		listaObj1.Add(new Objeto1 { PropObj1 = listaObj2 });
	
		var resultado = listaObj1.SelectMany(o => o.PropObj1, (objeto1, objeto2) => new { objeto1, objeto2 })
			    .SelectMany(o => o.objeto2.PropObj2, (objeto2, objeto3) => new { objeto2, objeto3 })
				.Where(o => o.objeto3.PropObj3 == 1).Select(o => new { o.objeto2.objeto1.PropObj1 }).ToList();
		foreach(var i in resultado) {
			WriteLine(i);
		}
	}
}

public class Objeto1 {
   public List<Objeto2> PropObj1 {get; set;}
}

public class Objeto2 {
   public List<Objeto3> PropObj2 {get; set;}
}

public class Objeto3 {
   public int PropObj3 {get; set;}
}

//https://pt.stackoverflow.com/q/80066/101
