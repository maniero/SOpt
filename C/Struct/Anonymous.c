struct Pessoa x;

struct { char nome[256]; } x;

struct Pessoa {
    char nome[256];
};
typedef Pessoa Pessoa;

Pessoa x;

//https://pt.stackoverflow.com/q/509033/101
