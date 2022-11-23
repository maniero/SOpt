using System.Collections.Generic;
using static System.Console;

List<Exemplo> lista = new() {new() { nIDState = 2 }, new() { nIDState = 3 }};
WriteLine(Contains(lista, 2));
WriteLine(Contains(lista, 3));
WriteLine(Contains(lista, 4));
					
static bool Contains(List<Exemplo> lista, int estado) {
	foreach (var item in lista) if (item.nIDState == estado) return true;
    return false;
}

class Exemplo {
	public int nIDState = 1;
}

//https://pt.stackoverflow.com/q/32934/101
