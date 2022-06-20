import java.util.Scanner;

class Program {
    public static void main(String[] args) {
        System.out.printf("Informe uma string:\n");
        String s = (new Scanner(System.in)).nextLine();
        String maius = "";
        String minus = "";
        for (char c : s.toCharArray()) {
            if (c >= 'a' && c <= 'z') maius += Character.toUpperCase(c);
            else maius += c;
            if (c >= 'A' && c <= 'Z') minus += Character.toLowerCase(c);
            else minus += c;
        }
        System.out.printf("\nResultado:\n%s\n%s\n", maius, minus);
    }
}

//https://pt.stackoverflow.com/q/556383/101
