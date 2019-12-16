class Teste : public Testando {
    String nome;
    int numero;
    public:
        Teste(String teste, String nome, int numero) : Testando(teste) {      
            this.nome = nome;
            this.numero = numero;
        }
}

//https://pt.stackoverflow.com/q/120162/101
