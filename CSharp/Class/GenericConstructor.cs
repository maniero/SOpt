//var objeto = new Classe(42);
var objeto = new Classe<int>(42);
var myObj = Factory.Create(42);
var o = Classe<bool>.Create(42);
System.Console.Write(o.campo.GetType());

public class Classe<T> {
    public readonly T campo;
    public Classe(T valor) => campo = valor;
	public static Classe<T1> Create<T1>(T1 valor) => new Classe<T1>(valor);
}

public class Factory {
    public static Classe<T> Create<T>(T valor) => new Classe<T>(valor);
}

//https://pt.stackoverflow.com/q/579364/101
