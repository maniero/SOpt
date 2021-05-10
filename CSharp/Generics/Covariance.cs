public class Program {
	public static void Main() {
		var dog = new Cachorro() { Nome = "Toy", Patas = 4, MesesGestacao = 3, Especie = "Cachorro" };
		IPet<Animal> p1 = new Pet<Cachorro>();
	}
}
class Animal {
	public string Especie { get; init; }
}
class Mamifero : Animal {
	public int MesesGestacao { get; init; }
}
class Cachorro : Mamifero {
	public string Nome { get; init; }
	public int Patas { get; init; }
}
interface IPet<out T> where T : Animal {
	public string Apelido { get; init; }
}
class Pet<T> : IPet<T> where T : Animal {
	public string Apelido { get; init; }
}

//https://pt.stackoverflow.com/q/508268/101
