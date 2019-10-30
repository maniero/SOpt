class A {
    public metodo() { System.out.println("A"); }
}
class B extends A {
    @override public metodo() { System.out.println("B"); }
}
class Principal {
    public static main() {
        B x = new B();
        teste(x); // imprime B porque B é derivado de A e o método é virtual
        A y = new A();
        teste(y); // imprime A
    }
    public static teste(A x) {
        x.metodo();
    }
}

class A {
    private metodo() { System.out.println("A"); }
}
class B extends A {
    public metodo() { System.out.println("B"); }
}
class Principal {
    public static main() {
        B x = new B();
        testeB(x); //Imprime B
        teste(x); //por ser privado, é final, e o compilador não tenta acessar o tipo derivado
        // não vai funcionar, teste() só consegue acessar o método de A, que é privado
        A y = new A();
        teste(y); //não vai funcionar
    }
    public static teste(A x) {
        x.metodo(); //não compila, o método não existe, métodos privados não são acessíveis fora da classe
    }
    public static testeB(B x) {
        x.metodo();
    }
}

class A {
    final public metodo() { System.out.println("A"); }
}
class B extends A {
    public metodo() { System.out.println("B"); }
}
class Principal {
    public static main() {
        B x = new B();
        testeB(x); //Imprime B, óbvio, não tem como errar
        teste(x); //Imprime A, não há polimorfismo, ele só entende o que há em A
        A y = new A();
        teste(y); //imprime A
    }
    public static teste(A x) {
        x.metodo();
    }
    public static testeB(B x) {
        x.metodo();
    }
}

//https://pt.stackoverflow.com/q/101038/101
