#include <iostream>

struct Brinquedo {
    int Objetos;
    int Bola;
    int Carrinho;
    int Caixa;
    int Dinamite;
    void func(int st_Bola, int st_Carrinho, int st_Caixa, int st_Dinamite) {
        Bola = st_Bola;
        Carrinho = st_Carrinho;
        Caixa = st_Caixa;
        Dinamite = st_Dinamite;
    }
};

int main() {
    Brinquedo brinquedo;
    //não fia sentido ter as duas variáveis aqui, cada uma fzendo algo totalmente diferente
    brinquedo.func(10,9,15,25);
    std::cout << brinquedo.Bola << brinquedo.Carrinho << brinquedo.Caixa << brinquedo.Dinamite;
}

//https://pt.stackoverflow.com/q/225091/101
