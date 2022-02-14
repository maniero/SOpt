class Main {
    public static void main(String args []) {
        Texto t = new Texto("a b c d e");
        t = t.adiciona(new Frase("x y")).adiciona(" f g h i");
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

    Texto adiciona(Frase fra) {
       t = t.concat(fra.frase);
       return this;
    }

    Texto adiciona(String s) {
        t = t.concat(s);
        return this;
    }

    public String toString() {
       return t;
    }
}

//https://pt.stackoverflow.com/q/542775/101
