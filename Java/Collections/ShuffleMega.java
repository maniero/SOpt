import java.util.*;

class AtividadeMegaSena {
    public static void main(String[] args) {
        Scanner teclado = new Scanner(System.in);
        System.out.println("Quantos jogos você quer fazer?");
        int numJogos = teclado.nextInt();
        List<Integer> numeros = new ArrayList<>();
        for (int i = 1; i <= 60; i++) numeros.add(i);
        for (int i = 1; i <= numJogos; i++) {
            Collections.shuffle(numeros);
            for (int j = 0; j < 6; j++) System.out.println(numeros.get(j));
            System.out.println();
        }
    }
}

//https://pt.stackoverflow.com/q/386549/101
