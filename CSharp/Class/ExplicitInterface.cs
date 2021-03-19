using static System.Console;
using System.Collections;
using System.Collections.Generic;

public class Program {
	public static void Main() {
		var x = new MyClasst<int>();
		WriteLine(((IEnumerable)x).GetEnumerator());
		WriteLine(x.GetEnumerator());
	}
}

public class MyClasst<T> : IEnumerable<T> {
    private T[] list;
	
	public IEnumerable Teste() => (IEnumerable)GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() {
		WriteLine("Explícita");
        return this.GetEnumerator();
    }

    public IEnumerator<T> GetEnumerator() {
        yield return this.list[0];
    }
}

//https://pt.stackoverflow.com/q/499982/101
