using System;
using static System.Console;
					
public class Program {
	public static void Main() {
		string[] meuArray = {"stack", "overflow","em", "português"};
		var meuSegmento = new ArraySegment<string>(meuArray, 2, (meuArray.Length - 2));
		string[] arraySegmentado = meuSegmento.ToArray();
		foreach (var item in arraySegmentado) WriteLine(item);
	}
}

//https://pt.stackoverflow.com/q/113891/101
