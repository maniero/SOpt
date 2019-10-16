import java.util.Scanner;

class Lampada {
	private boolean ligada = true;
	public void setLigada(boolean alteraEstado) {
	    this.ligada = alteraEstado;
	}
	public boolean isLigada() {
	    return ligada;
	}
}

class Main {
	public static final Scanner sc = new Scanner(System.in);
	public static void main (String [] args) {
		System.out.println("Comando 'ligar' ou 'desligar' lampada.");
		String comando = sc.nextLine();
		Lampada lampada = new Lampada();
	    switch (comando) {
	        case "ligar":
	        	lampada.setLigada(true);
	            System.out.println("Lampada ligada.");
	            break;
	        case "desligar":
	        	lampada.setLigada(false);
	            System.out.println("Lampada desligada.");
	            break;
	    }
    }
}

//https://pt.stackoverflow.com/q/416293/101
