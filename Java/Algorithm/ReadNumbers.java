import java.util.Scanner;
class SEP_06_exe2_p1 {
    public static void main(String args[]) {
        int[] x = new int[10];
        int y = 0;
        Scanner input = new Scanner(System.in);
        do {         
            System.out.print("Digite o " + (y + 1) + "º valor: ");
            x[y] = input.nextInt();
            y++; //incrementa 1 no y <== estava errado veja nota abaixo
        } while (y < 10);
        y = 0;
        do {         
            System.out.println(x[y]);
            y++;
        } while (y < 10);
    }
}

//https://pt.stackoverflow.com/q/35010/101
