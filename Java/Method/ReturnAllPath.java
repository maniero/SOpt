public class Biblioteca {
    private ArrayList<Exemplar> exemplares;
    public boolean emprestar(int codigo) {
       for (Exemplar e : exemplares) if (e.getCodigo() == codigo) return e.isDisponivel();
       return false;
    }
}

//https://pt.stackoverflow.com/q/415303/101
