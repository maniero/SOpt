import java.util.Scanner;

class Main {
    public static void main(String args[]){
        Scanner in = new Scanner(System.in);
        System.out.println("\nDigite o Alimento (Vegetariano, Peixe, Frango ou Carne): ");
        String alimento = in.nextLine();
        System.out.println(alimento.equals("Vegetariano") ? "É Vegetariano" : "nao é vegetariano");
    }
}

//https://pt.stackoverflow.com/q/55362/101
