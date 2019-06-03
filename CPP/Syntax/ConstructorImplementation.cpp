class Bispo: public Peca {
    public:
        Bispo(int cor);
        bool checaMovimento(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino);
        string desenha();
};

//https://pt.stackoverflow.com/q/385673/101
