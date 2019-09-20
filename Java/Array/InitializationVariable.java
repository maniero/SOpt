import java.util.Scanner;

class Exer4 {
    public static void main(String[] args) {
    	Scanner in = new Scanner (System.in);
        int alunos = in.nextInt();
 	    int notas[] = new int[alunos];
 	    int soma = 0;
	    for (int i = 0; i < alunos; i++) {
	    	notas[i] = in.nextInt();
 		    soma += notas[i];
	    }
		System.out.println(soma / alunos);
	}
}

//https://pt.stackoverflow.com/q/411367/101
