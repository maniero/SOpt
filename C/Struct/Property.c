typedef struct {
    int tipo, cod;
    int ano;
    char cidade[100], morada[100], animais[20], obs[100]; 
    float preco_min, preco_acons;
    char ativo;
} Imovel;

typedef struct {
    Imovel info;
    struct imovel *seguinte;
    struct imovel *anterior; 
} Imoveis;

//https://pt.stackoverflow.com/q/305225/101
