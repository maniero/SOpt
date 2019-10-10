using static System.Console;
					
public class Program {
	public static void Main() => WriteLine(new Animal().estaVivo);
}

public class Animal {
	public bool estaVivo, usaDrogas = false;
	private string Especie;
	public Animal() {
		estaVivo = true;
		WriteLine("Qual a espécie desse animal?");
		Especie = ReadLine();
		WriteLine(estaVivo); //debug
	}
}

//https://pt.stackoverflow.com/q/89256/101
