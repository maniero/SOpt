using static System.Console;
					
public class Program {
	public static void Main(){
		var instancia = Instancia.Factory();
		WriteLine(instancia.GetType());
	}
}

public class Instancia {
	private Instancia() {}
	public static Instancia Factory() {
		return new Instancia();
	}
}

//http://pt.stackoverflow.com/a/176781/101
