class Produto implements Comparable<Produto> {
    ...
    @Override
    public int compareTo(Produto outro) {
        return String.compare(this.nome, outro.nome);
    }
}

//https://pt.stackoverflow.com/q/344384/101
