//Isto continua com vários problemas, mas compila

interface Produto {
    void exibirNome(String nome);
}
 
class Revista implements Produto {
    @Override
    public void exibirNome(String nome) {
        System.out.println("Exibindo revista de nome: " + nome);
    }
}
 
class Teste {
    private Produto produto;
    String nome;
 
    public Teste(Produto produto) {
        this.produto = produto;
    }
 
    public Produto getProduto() {
        return produto;
    }
 
    @Override
    public String toString() {
    	produto.exibirNome(nome);
        return nome;
    }
}
 
class Ideone {
	public static void main(String[] args)	{
		Produto p = new Revista();
        Teste teste = new Teste(p);
        System.out.println(teste);
	}
}

//https://pt.stackoverflow.com/q/172121/101
