public abstract class Factory<T, U> where T : class  where U : class {
    public abstract T Build(U obj);
}
public class Quadrado {
    public int Largura { get; set; }
    public int Altura { get; set;}
}
public class Retangulo {
    public int Largura { get; set; }
    public int Altura { get; set; }
}
public class QuadradoFactory: Factory<Quadrado, Retangulo> {
    public override Quadrado Build(Retangulo o) => new Quadrado() { Largura = o.Largura, Altura = o.Altura };
}
public class Program {
    public static void Main() {
        var f = new QuadradoFactory();
        var r = new Retangulo(){ Largura = 2, Altura = 4 };
        var q = f.Build(r);
        System.Console.WriteLine("Largura: " + q.Largura + " Altura: " + q.Altura);
    }
}

//https://pt.stackoverflow.com/q/325885/101
