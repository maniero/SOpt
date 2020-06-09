import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line1 = scanner.nextLine();
        String[] a = line1.split(",");
        for (int i = a.length - 1; i >= 0; i--) System.out.print(a[i] + " ");
    }
}

//https://pt.stackoverflow.com/q/456523/101
