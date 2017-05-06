class HelloWorld {
    public static void main(String[] args) {
        long termo1 = 1;
        long termo2 = 2;
        long soma = 0;
        for (int i = 0; i < 10000; i++) {
            long novoTermo = termo1 + termo2;
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
