public interface View<T extends Role> {
    public boolean existe(T obj);
}

public class AlgumaClasse implements Role<Diretor> {
    public boolean existe(Diretor diretor) {
        for (Diretor d : this.tmDiretor.getLstDiretores()) if (d.getId().equals(diretor.getId())) return true;
        return false;
    }
}

//https://pt.stackoverflow.com/q/385877/101
