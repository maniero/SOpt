import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

class Exercicio1_string {
    public static void main(String[] args) {
        InputStreamReader c = new InputStreamReader(System.in);
        BufferedReader cd = new BufferedReader(c);
        String frase = "";
        char letra = ' ';
        System.out.println("Escreva uma frase: ");
        try {
            frase = cd.readLine();
        } catch (IOException e) {
            System.out.println("Erro de entrada");
        }
        System.out.println("Escreva uma letra para encontrar na frase: ");
        try {
            letra = cd.readLine().charAt(0);
        } catch (IOException e) {
            System.out.println("Erro de entrada");
        }
        int contador = 0;
        for (int caractere : frase.toCharArray()) if (caractere == letra) contador++;
        if (contador == 0) System.out.println("Nao existe a letra na frase");
        else System.out.println("A letra aparece " + contador + " vezes");
    }
}

//https://pt.stackoverflow.com/q/328104/101
