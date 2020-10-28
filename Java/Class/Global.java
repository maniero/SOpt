public final class Global {
    private Global() {} // só pra garantir que não haja instâncias dela
    private static int[] vetor;
    public static int[] getVetor() { return vetor; }
    public static void setVetor(int[] vetor) { this.vetor = vetor; }
    //aqui pode colocar vários outros dados se eles forem relacionados
    //o ideal é criar classe globais para cada necessidade
    //nem sempre é necessário usar getter e setter, o campo público pode ser suficiente
    //é possível criar outras operações específicas de acordo com a necessidade
    //por exemplo pode pegar e setar um elemento do vetor
}

//https://pt.stackoverflow.com/q/134576/101
