class Main {
     public static void main(String[] args) {
        A a = new A();
        a.metodo1();
        A b = new B();
        b.metodo1();
        A c = new B();
        c.metodo2();
     }
}

class A {
    public void metodo1() { System.out.println("A"); }
    public void metodo2() { System.out.println("A"); }
}
class B extends A {
    @Override public void metodo1() { System.out.println("B"); }
    public void metodo2() { System.out.println("B"); }
}

//https://pt.stackoverflow.com/q/89218/101
