using static System.Console;
using System.Collections.Generic;
using System.Linq;

public class Program {
	public static void Main() {
        foreach (var item in CriarLista(1, 2, 3, 4, 5, 6)) WriteLine(item);
	}
    public static List<T> CriarLista<T>(params T[] pars) => pars.ToList();
}

//https://pt.stackoverflow.com/q/214927/101
