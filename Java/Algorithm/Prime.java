import java.util.Scanner;
public class Main {
    public static void main(String [] args){
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
         for (int i = 1; i <= n; i++) {
            int v = sc.nextInt();
    	    int contador = 0;
            for (int j = 1; j <= v; j++) {
                if (v % j == 0){
                    contador++;
                    if (contador == 3) break;
                }
            }
            if (contador == 2) System.out.println("PRIME");
            else System.out.println("NOT PRIME");
        }
    }
}

//https://pt.stackoverflow.com/q/138347/101
