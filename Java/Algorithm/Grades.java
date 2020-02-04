import java.util.*;

class Main {
	public static void main (String[] args) {
		var s = new Scanner(System.in);
		var notas = new ArrayList<Integer>();
		System.out.println("Entre com notas de 0 a 10");
		var num = 0;
		while (num != -1) { 
		    num = s.nextInt(); //armazena em variável para poder usar onde quiser
		    if (num != -1) notas.add(num);
		}
		System.out.println(notas.toString());
	}
}

//https://pt.stackoverflow.com/q/138124/101
