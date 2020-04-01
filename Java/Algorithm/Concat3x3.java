class HelloWorld {
	public static void main(String[] args) {
		String[] vetor = {"aaa", "aaa", "aaa", "bbb", "bbb", "bbb", "ccc", "ccc", "ccc", "ddd", "ddd", "ddd"};
        String[] novoVetor = new String[vetor.length / 3];
        for (int i = 0; i < vetor.length; i += 3) novoVetor[i / 3] = vetor[i] + vetor[i + 1] + vetor[i + 2];
        for (String item : novoVetor) System.out.println(item);
	}
}

//https://pt.stackoverflow.com/q/172740/101
