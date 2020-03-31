class Teste30 {
    public static void main(String[] args) {
        String teste = "Isso funciona mesmo, ok?";
        String [] vetor = teste.split(" ");
        String aqui = vetor[0];
        String ali = vetor[1];
        String acola = vetor[3];
        String there = vetor[4];
        for (String nome : vetor) System.out.println(nome);
    }
}

//https://pt.stackoverflow.com/q/172144/101
