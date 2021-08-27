class Homem {
    protected void ouvir() {
        System.out.print("Mamifero ouvindo ");
        ver();
    }
    protected void andar() {
        System.out.print("Primata andando ");
        ouvir();
    }
    protected void ver() {
        System.out.print("Homem vendo ");
    }
}
class Main {
    public static void main(String[] args) {
        Homem m = new Homem();
        m.andar();
    }
}

//https://pt.stackoverflow.com/q/410611/101
