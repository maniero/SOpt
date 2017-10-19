package gerarOrganizar;
import java.util.Random;
public class GerarOrganizar {
    public static void main(String[] args) {
        int[] numerosAleatorios = new int[100];
        Random geradorRandomico = new Random();
        for(int i = 0; i < 100; i++) {
            numerosAleatorios[i] = geradorRandomico.nextInt(250);
            System.out.println(numerosAleatorios[i]); //deixei para você ver funcionando
        }
    }
}

//https://pt.stackoverflow.com/q/35290/101
