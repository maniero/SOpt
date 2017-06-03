
import java.util.*;

class HelloWorld {
	public static void main (String[] args) {
		ArrayList<Candidato> candidato = new ArrayList<>();
		candidato.add(new Candidato("joao", 4));
		candidato.add(new Candidato("jose", 2));
		candidato.add(new Candidato("joaquim", 7));
	    int maiorVotos = 0;
	    Candidato maiorCandidato = null;
	    for (Candidato e: candidato) {
	        if(e.votos > maiorVotos) {
	            maiorVotos = e.votos;
	            maiorCandidato = e;
	        }
	    }
	    if (maiorCandidato != null) {
	        System.out.println("O presidente eleito é: " + maiorCandidato.nome);
	    }
	}
}

class Candidato {
	public String nome;
	public int votos;
	public Candidato (String nome, int votos) {
		this.nome = nome;
		this.votos = votos;
	}
}

//https://pt.stackoverflow.com/q/209899/101
