using static System.Console;
using System.Collections.Generic;					
public class Program {
	public static void Main() {
		ImprimeValores(null);
		ImprimeValores(new List<int>());
		ImprimeValores(new List<int> { 1, 2, 3 });
	}
    static void ImprimeValores(IList<int> values) {
        if (values != null) foreach(int v in values) WriteLine("value:" + v);
    }
}

//https://pt.stackoverflow.com/q/129966/101
