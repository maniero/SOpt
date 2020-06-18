import java.util.*;
import java.lang.*;
import java.io.*;

class Main {
	public static void main (String[] args)	{
		ArrayList<Candidato> Candidatos = new ArrayList<Candidato>();
        Scanner e = new Scanner(System.in);
        int op;
		do {
		    System.out.println("Cadastrar 1 ");
		    System.out.println("Consultar 2");
		    System.out.println("Votar     3");
		    System.out.println("Finalizar 4");
		    op = e .nextInt();
		    if (op == 1) {
		        System.out.println("digite o numero");
		        String numero = e.next();
		        System.out.println("digite o nome ");
		        String nome = e.next();
		        System.out.println("digite o partido");
		        String partido = e.next();
		        Candidatos.add(new Candidato(numero, nome, partido));
		    } else if (op == 2) {
		        System.out.println("Digite um numero");
		        String n = e.next();
		        for (int i = 0; i < Candidatos.size(); i++) {
		            if (Candidatos.get(i).getNumero().equals(n)) {
		                System.out.println(Candidatos.get(i).getNome() + ", " + Candidatos.get(i).getPartido() + ", " + Candidatos.get(i).getVotos());
		            }
		        }
		    } else if (op == 3) {
		        System.out.println("Digite um numero de quem deseja votar");
		        String n = e.next();
		        int i = 0;
   		        for (; i < Candidatos.size(); i++) {
		            if (Candidatos.get(i).getNumero().equals(n)) {
		                break;
		            }
   		        }
   		        if (i != Candidatos.size()) Candidatos.get(i).Votar();
		    }
		} while (op !=4 );
	}
}

class Candidato {
    String nome;
    String partido;
    String numero;
    int votos = 0;
    public Candidato(String numero, String nome, String partido) {
    	this.numero = numero;
    	this.nome = nome;
    	this.partido = partido;
    }
    public void Votar() { votos++; }
    public int getVotos() { return votos; }
    public String getNumero() { return numero; }
    public String getNome() { return nome; }
    public String getPartido() { return partido; }
}

//https://pt.stackoverflow.com/q/241092/101
