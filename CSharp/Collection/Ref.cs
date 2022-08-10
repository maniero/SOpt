using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public struct Teste {
	public int Numero = 0;
	public void SetNumero(int i) {
		this.Numero = i;
	}
}
					
public class Program {
	public static void Main() {
		var list = new List<Teste>();
		list.EnsureCapacity(100);
		for (var i = 0; i < 100; i++) list.Add(new Teste());
        var list2 = CollectionsMarshal.AsSpan(list);
		for (var i = 0; i < list.Count; i++) {
			ref var item = ref list2[i];
			item.SetNumero(i);
		}
		for (var i = 0; i < list.Count; i++) Console.WriteLine(list[i].Numero);
	}
}

//https://pt.stackoverflow.com/q/561052/101
