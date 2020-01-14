using static System.Console;
using System;
using System.Reflection;

public class Program {
    public static void Main(string[] args) {
		foreach (var method in typeof(String).GetMethods(BindingFlags.Public | BindingFlags.Instance)) WriteLine(method.Name);
		WriteLine();
		var x = 1;
		foreach (var method in x.GetType().GetMethods()) WriteLine(method.Name);
    }
}

//https://pt.stackoverflow.com/q/129060/101
