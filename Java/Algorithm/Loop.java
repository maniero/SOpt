class Contador {
    public static void main(String[] args) {
        int a = 1;
        while ( a < 11) {
            int b = 1;
            while (b < 11) System.out.printf("%02d - %02d, ", a, b++);
            System.out.println();
            a++;
        }
    }
}

//https://pt.stackoverflow.com/q/286931/101
