import java.util.Scanner;

class OrdenarNomes {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String[] nomes = new String[20];
        for (int i = 0; i < nomes.length; i++) {
            System.out.println("Informe os nomes: ");
            nomes[i] = in.next();
        }
        String x = " ";
        for (int i = 1; i < nomes.length - 1; i++) {
            for (int j = i + 1; j < nomes.length; j++) {
                if (nomes[i].CompareTo(nomes[j]) > 0) {
                    x = nomes[i];
                    nomes[i] = nomes[j];
                    nomes[j] = x;
                }
            }
        }
        for (int i = 0; i < nomes.length; i++) System.out.print(nomes[i]+" ");
    }    
}

//https://pt.stackoverflow.com/q/392679/101
