import java.util.*;

class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int [] vet = new int[4];
        for (int i = 0; i < 4 ; i++) {
            try {
                System.out.println("Informe o " + (i + 1) + "º numero: ");
                vet[i] = sc.nextInt();
            }
            catch (InputMismatchException e) { //note que eu capturei a exceção certa
                System.out.println("Valor inválido");
                sc.nextLine(); //precisa disso pra limpar o buffer
                i--;
            }
        }
    }
}

//https://pt.stackoverflow.com/q/457414/101
