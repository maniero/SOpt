using static System.Console;
using System;
using System.Reflection;

public class Program {
    public static void Main(string[] args) {
		var x = new Derived();
		x.Method();
    }
}

[AttributeUsage(AttributeTargets.All)]
public class MyAttribute : Attribute {
    public MyAttribute() => WriteLine("Executei o atributo...");
}


class Base {
	public Base() { 
		foreach (var method in this.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance)) method.GetCustomAttributes(true);
	}
}

class Derived : Base {
	public Derived() => WriteLine("Executei o construtor da classe...");
	[My]
    public void Method() => WriteLine("Executei o método...");
}

//https://pt.stackoverflow.com/q/127867/101
