using System;
using static System.Console;
using System.Reflection;
					
public class Program {
	public static void Main() {
		int i = 0;
		Objeto obj = new Objeto();
		string[] array = { "1", "01/01/2015", "abc", "0.123" };
		foreach(PropertyInfo inf in typeof(Objeto).GetProperties()) {
            inf.SetValue(obj, Convert.ChangeType(array[i], inf.PropertyType));
			i++;
		}
		WriteLine($"Número: {obj._numero}");
		WriteLine($"Número: {obj._data}");
		WriteLine($"Número: {obj._palavra}");
		WriteLine($"Número: {obj._decimal}");
	}
}

public class Objeto {
    public int _numero { get; set; }
    public DateTime _data { get; set; }
    public string _palavra { get; set; }
    public decimal _decimal { get; set; }
}

//https://pt.stackoverflow.com/q/53143/101
