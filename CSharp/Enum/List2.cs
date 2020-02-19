using System;
using System.Linq;
using static System.Console;
					
public class Program {
	public static void Main() {
		var lista = Enum.GetValues(typeof(TiposHospedagem)).Cast<int>().ToList();
		foreach (var item in lista) WriteLine(item);
    }
}

public enum TiposHospedagem {
    Casa = 1,
    Hotel = 2,
    Pousada = 3,
    CasaCampo = 4
}

//https://pt.stackoverflow.com/q/150208/101
