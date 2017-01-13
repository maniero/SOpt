using System;
using System.Reflection;
					
public class Program {
	public static void Main() {
		var objeto = new Tipo() { x = 1, a = "aaa" };
		var objeto2 = ObjectUtil<Tipo>.Clone(objeto);
		Console.WriteLine(objeto2.x);
	}
}

static class ObjectUtil<T> {
	public static T Clone(T obj) {
		Type type = obj.GetType();
		var fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
		var cloned = Activator.CreateInstance(type);
		for (int i = 0; i < fields.Length; i++) {
			fields[i].SetValue(cloned, fields[i].GetValue(obj));
		}
		return (T)cloned;
	}	
}

class Tipo {
	public int x;
	public string a;
	public TimeZoneInfo t;
}

//http://pt.stackoverflow.com/a/177147/101
