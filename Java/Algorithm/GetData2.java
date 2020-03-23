import java.util.Scanner;

class NotaAluno {
	public static void main(String[] args) {
	    Scanner entrada = new Scanner(System.in);
	    int notaAluno[] = new int[3];
	    int total = 0;
	    for(int i = 0; i < notaAluno.length; i++) {
	        System.out.println("Informe o numero da nota do aluno [" + i + "]" );
	        notaAluno[i] = entrada.nextInt(); 
	        total += notaAluno[i];
	    }
	    System.out.println("A Media dos alunos eh " + total / 3);
	}
}

//https://pt.stackoverflow.com/q/165510/101
