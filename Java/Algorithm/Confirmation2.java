import java.util.Scanner;

class Main {
    public static void main(String[] args) {
    	Scanner sc = new Scanner(System.in);
        while (true) {
	        System.out.println("Confirma?");
            if (sc.nextLine().equals("s")) break;
        }
        System.out.println("confirmado");
        sc.close();
    }
}

//https://pt.stackoverflow.com/q/431680/101
