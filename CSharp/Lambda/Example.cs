using System;
using static System.Console;

public class Program {
	public static void Main() => Exemplo(() => WriteLine("alguma coisa"));
	public static void Exemplo(Action outraFunction) => outraFunction();
}

//https://pt.stackoverflow.com/q/320574/101
