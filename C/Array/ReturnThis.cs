using static System.Console;

public class Program {
	public static void Main() {
		var variavel = new ClasseA().Metodo();
		WriteLine(variavel);
	}
}

public class ClasseA {
	public ClasseA Metodo() => this;
}

//https://pt.stackoverflow.com/q/393087/101
