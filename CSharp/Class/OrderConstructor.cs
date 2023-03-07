using static System.Console;

public static class Program {
	public static void Main(string[] args) => new Derivada(1, "");
}

public class Inicial {
	public Inicial() => WriteLine("Inicial"); //chamará base(), especificamente Object()
}

public class Base : Inicial {
	public Base(int x) : base() => WriteLine("Base");
}

public class Derivada : Base {
	public Derivada(int x, string y) : base(x) => WriteLine("Derivada");
}

//https://pt.stackoverflow.com/q/579238/101
