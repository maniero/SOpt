interface Teste {
    default public void teste() {
        System.out.println("teste");
    }
}

class Classe { };

class NovaClasse extends Classe implements Teste { }

class HelloWorld {
    public static void main(String[] args) {
        NovaClasse teste = new NovaClasse();
        teste.teste(); //vai imprimir a palavra teste conforme definido na interface
    }
}

//http://pt.stackoverflow.com/q/22718/101
