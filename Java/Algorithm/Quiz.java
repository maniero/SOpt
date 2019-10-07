import java.util.*;

class Main {
    public static void main(String[] args) {
	    Scanner input = new Scanner(System.in);
	    boolean acertou = false;
	    List<String> respostas = new ArrayList<String>();
	    respostas.add("Porta OR");
	    respostas.add("Porta XOR");
	    respostas.add("Porta AND");
	    respostas.add("Porta NOR");
	    respostas.add("Porta NOT");
	    int opcaoCorreta = 4;
	    Collections.shuffle(respostas);
	    while (true) {
	        System.out.println("(Conceitos de Computação) Que porta lógica utilizamos para inverter o sinal lógico recebido?");
	        for (int i = 0; i < 5; i++) System.out.println(((char)(i + 'a')) + ") " + respostas.get(i));
	        System.out.println("Resposta: ");
	        char opcao = input.next().charAt(0);
	        if (opcao - 'a' == opcaoCorreta) {
	        	System.out.println("Resposta correta");
	        	break;
	        }
	    }
	    input.close();
	}
}

//https://pt.stackoverflow.com/q/414404/101
