using static System.Console;
					
public class Program {
	public static void Main() {
		var cA = new ClasseA();
		var cB = new ClasseB();
		cA.Metodo1(cA);
		cB.Metodo1(cB);
	}
}

public interface IClasse<T> where T : IClasse<T> {
	void Metodo1(T parametro);
}

public class ClasseA : IClasse<ClasseA> {
	public void Metodo1(ClasseA parametro) {
		WriteLine("ClasseA");
		return;
	}
}

public class ClasseB : IClasse<ClasseB> {
	public void Metodo1(ClasseB parametro) {
		WriteLine("ClasseB");
		return;
	}
}

//https://pt.stackoverflow.com/q/47925/101
