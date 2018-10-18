using Foo = Foo<int>;
					
public class Program {
    public static void Main() {
        var a = new Foo<int>();
        var b = new Foo();
    }
}
public class Foo<T> {
    public T Bar { get; set; }
}

//https://pt.stackoverflow.com/q/336844/101
