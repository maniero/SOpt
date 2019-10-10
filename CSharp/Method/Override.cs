using static System.Console;
					
class A {
    virtual public void metodo1() => WriteLine("A");
    public void metodo2() => WriteLine("A");
}
class B : A {
    override public void metodo1() => WriteLine("B");
    public void metodo2() => WriteLine("B");
}

public class HelloWorld {
     public static void Main() {
        A a = new A();
        a.metodo1();
        A b = new B();
        b.metodo1();
        A c = new B();
        c.metodo2();
     }
}

//https://pt.stackoverflow.com/q/89218/101
