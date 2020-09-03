import java.util.*;
    
public class Main {
    public static void main(String[] args) {
        String palavra = "Java";    
        Scanner in = new Scanner(System.in);
        System.out.print("Informe um inteiro: ");
        int indice = in.nextInt();
        try {
            System.out.println("O caractere no índice informado é " + palavra.charAt(indice));
        }
        catch(StringIndexOutOfBoundsException e) {
            System.out.println("Erro:" + e.getMessage());
        }
    }
}

//http://pt.stackoverflow.com/q/17025/101
