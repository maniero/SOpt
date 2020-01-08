class Ideone {
	public static void main (String[] args)	{
		Vector<Integer> a = new Vector<Integer>();
		a.adicionar(1);
		a.adicionar(2);
		a.adicionar(3);
		a.adicionar(4);
		a.adicionar(5);
		System.out.println(a.pegar(3));
		System.out.println(a.pegarPrimeiro());
		System.out.println(a.pegarUltimo());
		System.out.println(a.tamanho());
		System.out.println(a.vazio());
		System.out.println(a.procurar(3));
		System.out.println(a.removerElemento(3));
		System.out.println(a.remover(2));
		System.out.println(a.removerInicio());
		System.out.println(a.removerFim());
		System.out.println(a.pegar(0));
		System.out.println(a.tamanho());
		System.out.println(a.vazio());
		System.out.println(a.remover(2));
		System.out.println(a.removerInicio());
		System.out.println(a.removerFim());
		a.limpar();
	}
}

class Vector<T> {
    T[] vetor;
    int qntElementos = 0;
    public Vector(int tam) {
        vetor = (T[]) new Comparable[tam];
    }
    public Vector() {
        this(4);
    }
    public void adicionar(T elemento) {
        if (tamanho() == vetor.length) redimensionar();
        vetor[tamanho()] = elemento;
        qntElementos++;
    }
    public T pegar(int posicao) {
        if (vazio() || posicao < 0 || posicao >= tamanho()) throw new ArrayIndexOutOfBoundsException("Posição fora da faixa permitida");
        return vetor[posicao];
    }
    public T pegarPrimeiro() {
        if (vazio()) throw new ArrayIndexOutOfBoundsException("Posição fora da faixa permitida");
        return vetor[0];
    }
    public T pegarUltimo() {
        if (vazio()) throw new ArrayIndexOutOfBoundsException("Posição fora da faiza permitida");
        return vetor[qntElementos - 1];
    }
    public int procurar(T elemento) {
        for (int i = 0; i < qntElementos; i++) {
            if (vetor[i].equals(elemento)) return i;
        }
        return -1;
    }
    public boolean removerElemento(T elemento) {
        return remover(procurar(elemento));
    }
    public boolean remover(int posicao) {
        if (!vazio() && posicao >= 0 && posicao < tamanho()) {
            for (int i = posicao; i < qntElementos; i++) vetor[i] = vetor[i + 1];
            vetor[tamanho()] = null;
            qntElementos--;
            return true;
        } else {
            return false;
        }
    }
    public boolean removerInicio() {
        if (vazio()) return false;
        for (int i = 0; i < qntElementos; i++) vetor[i] = vetor[i + 1];
        qntElementos--;
        return true;
    }
    public boolean removerFim() {
        if (vazio()) return false;
        vetor[tamanho()] = null;
        qntElementos--;
        return true;
    }
    public int tamanho() {
        return qntElementos;
    }
    public boolean vazio() {
        return tamanho() == 0;
    }
    public void limpar() {
        vetor = (T[]) new Comparable[4];
    }
    private void redimensionar() {
        T[] novoVetor = (T[]) new Comparable[vetor.length * 2];
        if (vetor.length == tamanho()) {
            for (int i = 0; i < vetor.length; i++) novoVetor[i] = vetor[i];
            vetor = novoVetor;
        }
    }
}

//https://pt.stackoverflow.com/q/126968/101
