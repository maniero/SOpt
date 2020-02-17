import java.util.Scanner;

public class TesteCase {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        while (true) {
            System.out.println("\nMenu Principal\n");
            System.out.println(" 1) Vender Passagem");
            System.out.println(" 2) Cancelar Passagem");
            System.out.println(" 3) Relatório de Faturamento");
            System.out.println(" 4) Consultar Total de Lugares Disponíveis");
            System.out.println(" 5) Atualizar Informações do Piloto");
            System.out.println(" 6) Atualizar Informações do Co-Piloto");
            System.out.println(" 7) Atualizar Informações do Comissario");
            System.out.println(" 8) Sair do programa\n");
            int menu = input.nextInt();
            switch (menu) {
            case 1:
                // Aceita overbook!
                System.out.print("case1 ");
                break;
            case 2:
                System.out.print("case2 ");
                break;
            case 3:
                System.out.print("case3 ");
                break;
            case 4:
                System.out.print("case4 ");
                break;
            case 5:
                System.out.println("case5 ");
                break;
            case 6:
                System.out.println("case6 ");
                break;
            case 7:// a partir do 7 ele termina o programa
                System.out.println("case7 ");
                break;
            case 8:
                System.out.println("case8 ");
                break finaliza;
            default:
                System.out.println("default ");
                break;
            }
        }
     finaliza:
    }
}

//https://pt.stackoverflow.com/q/146875/101
