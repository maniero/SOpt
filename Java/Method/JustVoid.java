class Main {
    public static void main(String args []) {
        Texto t = new Texto("a b c d e");
        t.adiciona(new Frase("x y"));
        t.adiciona(" f g h i");
        System.out.println(t);
    }
} 

class Frase {
    String frase;

    Frase(String frase) {
        this.frase = frase;
    }
}

class Texto {
    String t;

    Texto(String t) {
        this.t = t;
    }

    void adiciona(Frase fra) {
       t = t.concat(fra.frase);
    }

    void adiciona(String s) {
        t = t.concat(s);
    }

    public String toString() {
       return t;
    }
}

//https://pt.stackoverflow.com/q/542775/101
