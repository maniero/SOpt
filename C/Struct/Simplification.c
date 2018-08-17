typedef struct no {
    int dado;
    struct no *proximo;
} No;

typedef struct {
    No *inicio;
    No *fim;
} Fila;

//https://pt.stackoverflow.com/q/322225/101
