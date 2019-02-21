import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        ArrayList<Integer> lista = new ArrayList<>();
        int soma = 0;
        int menor = 999;
        int maior = 0;
        System.out.println("Digite 0 para terminar");
        for (;;) {
            System.out.println("Digite um número: ");
            int num = s.nextInt(); 
            if (num == 0) break;
            lista.add(num);
            soma += num;
            maior = Math.max(maior, num);
            menor = Math.min( menor, num);
        }
        for (Integer integer : lista) System.out.println(integer);
        System.out.println("A média de idade é " + (soma / lista.size()));
        System.out.println("A maior idade é " + maior);
        System.out.println("A menor idade é " + menor);
    }
}

//https://pt.stackoverflow.com/q/46136/101
