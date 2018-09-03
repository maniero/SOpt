public abstract class Factory<T> where T : class {
    public abstract T Build<U>(U obj) where U : class;
}
public class Quadrado {
    public int Largura { get; set; }
    public int Altura { get; set;}
}
public class Retangulo {
    public int Largura { get; set; }
    public int Altura { get; set; }
}
public class QuadradoFactory: Factory<Quadrado> {
    public override Quadrado Build<U>(U o) {
		var obj = o as Retangulo;
		if (obj == null) return null;
		return new Quadrado() { Largura = obj.Largura, Altura = obj.Altura };
	}
}
public class Program {
    public static void Main() {
        var f = new QuadradoFactory();
        var r = new Retangulo(){ Largura = 2, Altura = 4 };
        var q = f.Build<Retangulo>(r);
        System.Console.WriteLine("Largura: " + q.Largura + " Altura: " + q.Altura);
    }
}

//https://pt.stackoverflow.com/q/325885/101
