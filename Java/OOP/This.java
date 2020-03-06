public class Externa {
    private int x;
    public class Interna {
        private int x;
        public int exemplo() {
            return Externa.this.x;
        }
    }
}

class Tipo {
    private int variavel;
    public void exemplo(int x) {
        variavel = x;
    }
}

class Tipo {
    private int variavel;
    public void exemplo(Tipo this, int x) {
        this.variavel = x;
    }
}

class Tipo {
    public void exemplo(Tipo this, int x) { //já escrito sem o açúcar sintático
        metodoDeOutraClasse(this, x); //passa o objeto atual e o parâmetro x
    }
}

class Tipo {
    public Tipo(int x) {
        System.out.println(x);
    }
    public Tipo() {
        this(1);
    }
}

//https://pt.stackoverflow.com/q/154186/101
