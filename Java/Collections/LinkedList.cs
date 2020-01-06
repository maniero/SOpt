class no {
	public int dado;
	public no prox;
}

class lista {
	no ini = null;
	no fim = null;
	
	public void inserir(int num) {
	    no novo = new no();
	    novo.dado = num;
	    novo.prox = null;
	    if (ini == null) {
	        ini = novo;
	    } else {
	        fim.prox = novo;
	    }
	    fim = novo;
	}
	
	public void imp() {
	    no x = ini;
	    while (x != null) {
	        System.out.println(x.dado);
	        x = x.prox;
	    }
	}
	
	public void remover(int num){
		no ant = null;
		no atual = ini;
		while (atual != null) {
			if (atual.dado == num) {
				ant.prox = atual.prox;
			}
			ant = atual;
			atual = atual.prox;
		}
	}
}

class Teste {
	public static void main(String[] args) {
	    lista lst = new lista();
	    lst.remover(8);
	    lst.inserir(15);
	    lst.inserir(8);
	    lst.imp();
	    lst.remover(8);
	    lst.imp();
	}
}

//https://pt.stackoverflow.com/q/125038/101
