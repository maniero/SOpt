class HelloWorld {
	public static void main (String[] args) {
		Aluno aluno = new Aluno("joao", 1, 8f, 6f);
		aluno.exibir();
	}
}

class Aluno {
    private String nome;
    private int matricula;
    private float n1, n2;

	public Aluno(String nome, int matricula, float n1, float n2) {
	    this.nome = nome;
	    this.matricula = matricula;
	    this.n1 = n1;
	    this.n2 = n2;
	}
	
	public float media() {
	    return (n1 + n2) / 2;
	}
	
	public void exibir() {
	    System.out.println("Nome:" +nome);
	    System.out.println("Matrícula:" + matricula);
	    System.out.println("Nota 1:" + n1);
	    System.out.println("Nota 2:" + n2);
	    System.out.println("A média é:" + media());
	}
}

//https://pt.stackoverflow.com/q/204494/101
