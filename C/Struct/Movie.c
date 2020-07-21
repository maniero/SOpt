typedef struct {
    const char *nome;
    //outros campos
} Filme;

typedef struct {
    const char *nome;
    //outros campos
} Ator;

typedef struct {
    Filme *filme;
    Ator *ator;
} AmarracaoFilmeAtor;

//https://pt.stackoverflow.com/q/303988/101
