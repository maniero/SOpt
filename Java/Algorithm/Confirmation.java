import java.util.Scanner;

class Main {
    public static void main(String[] args) {
    	Scanner sc = new Scanner(System.in);
        String resp = " ";
        while (!resp.equals("s")) {
	        System.out.println("Confirma?");
            resp = sc.nextLine();
        }
        System.out.println("confirmado");
        sc.close();
    }
}

//https://pt.stackoverflow.com/q/431680/101
