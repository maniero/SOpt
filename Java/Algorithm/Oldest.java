import java.util.Scanner;

class Pessoa {
    public String nome;
    public int idade;
}
class Programa {
    public static String comparaIdade(Pessoa[] pessoa) {
        int maior = pessoa[0].idade;
        int indice = 0;
        for (int i = 1; i < 3; i++) {
        	System.out.println(pessoa[i].idade);
            if (pessoa[i].idade > maior) {
                maior = pessoa[i].idade;
                indice = i;
            }
        }
        return pessoa[indice].nome;
    }

    public static void main(String[] args){
        Pessoa[] pessoa = new Pessoa[3];
        Scanner input = new Scanner(System.in);
        for (int i = 0; i < 3; i++) {
        	pessoa[i] = new Pessoa();
            System.out.println("Digite o nome da pessoa: ");
            pessoa[i].nome = input.nextLine();
            System.out.println("Digite a idade da pessoa: ");
            pessoa[i].idade = input.nextInt();
            input.nextLine();
        }
        System.out.printf("Nome da pessoa mais velha: %s", comparaIdade(pessoa));
    }
}

//https://pt.stackoverflow.com/q/235770/101
