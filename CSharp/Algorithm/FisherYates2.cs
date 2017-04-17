using static System.Console;
using System.Collections.Generic;
using System.Linq;

public static class Sorteio {
	public static void Main() {
		var lista = new List<string>() { "Alaor", "Joseval", "Salustiano", "Gomide", "Castro" };
		foreach (string value in lista.Shuffle()) {
			WriteLine(value);
		}
		WriteLine("////////");
		foreach (string value in lista.Shuffle().Take(3)) {
			WriteLine(value);
		}
	}
}

namespace System.Collections.Generic {
	public static class IEnumerableExt {
		static Random r = new Random(DateTime.Now.Millisecond);
		
		public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> list) {
			T[] array = list.ToArray();
			for (int i = array.Length - 1; i > 0; i--) {
				int j = r.Next(i + 1);
				T tmp = array[j];
				array[j] = array[i];
				array[i] = tmp;
			}
			foreach(var item in array) {
				yield return item;
			}
		}
	}
}

//https://pt.stackoverflow.com/q/17783/101
