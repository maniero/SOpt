class Base {
    Base() {
        System.out.println("Construção Base");
        metodo();
    }
    void metodo() {
        System.out.println("Método em Base");
    }
}

class Derivada extends Base {
    Derivada() {
        System.out.println("Construção Derivada");
    }
    @Override
    void metodo() {
        System.out.println("Método em Derivada");
    }
}

class Ideone {
    public static void main(String args[]) {
        Base base = new Base();
        base.metodo();
        System.out.println("------------------------");
        Derivada derivada = new Derivada();
        derivada.metodo();
    }
}

//https://pt.stackoverflow.com/q/128233/101
