class Main {
    public static void main(String[] args) {
        int termo1 = 1;
        int termo2 = 2;
        int soma = 0;
        while (termo2 < 100000) {
            int novoTermo = termo1 + termo2;
            if (novoTermo % 2 == 0) {
                soma += novoTermo;
            }
            termo1 = termo2;
            termo2 = novoTermo;
        }
        System.out.println(soma);
    }
}

//https://pt.stackoverflow.com/q/202847/101
