using System;
using static System.Console;
using System.Collections.Generic;
					
public class Program {
	public static void Main() {
		var lista = new List<int>();
		foreach (int item in Enum.GetValues(typeof(TiposHospedagem))) lista.Add(item);
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
