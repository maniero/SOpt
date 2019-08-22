import java.util.Scanner;

class Alimento {
    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        System.out.println("\nDigite o Alimento (Vegetariano, Peixe, Frango ou Carne): ");
        String alimento = in.nextLine();
        System.out.println("\nDigite a Bebida (Chá, Refri Diet, Suco de melancia ou Suco de Laranja): ");
        String bebida = in.nextLine();
        System.out.println("\nDigite a Sobremesa (Abacaxi, Sorvete, Sorvete Diet ou Mousse): ");
        String sobremesa = in.nextLine();
        int calorias = 350;
        int caloriasbebida = 100;
        int caloriassobremesa = 200;
	    if (alimento.toLowerCase().equals("vegetariano")) calorias = 180;
	    else if (alimento.toLowerCase().equals("peixe")) calorias = 230;
	    else if (alimento.toLowerCase().equals("frango")) calorias = 250;
	    if (bebida.toLowerCase().equals("chá")) caloriasbebida = 20;
	    else if (bebida.toLowerCase().equals("refri diet")) caloriasbebida = 65;
	    else if (bebida.toLowerCase().equals("suco de melancia")) caloriasbebida = 70;
	    if (sobremesa.toLowerCase().equals("abacaxi")) caloriassobremesa = 75;
	    else if (sobremesa.toLowerCase().equals("sorvete")) caloriassobremesa = 170;
	    else if (sobremesa.toLowerCase().equals("sorvete diet")) caloriassobremesa = 110;
	    int resultado = calorias + caloriasbebida + caloriassobremesa;
	    System.out.println("Total de Calorias da Refeição: " + resultado);
	}
}

//https://pt.stackoverflow.com/q/55367/101
