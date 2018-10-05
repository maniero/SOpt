#include <stdio.h>
#include <stdlib.h>

typedef struct {
    int codigo;
    int estoque;
} Cadastro;

void imprimir(Cadastro *cadastro, int n) {
    printf ("\n\n---------RESULTADO DOS PEDIDOS DOS CLIENTES-------\n\n");
    for (int i = 0; i < n; i++) {
        printf("Código da mercadoria %d: %d \n", i + 1, cadastro[i].codigo);
        printf("Quantidade da mercadoria no estoque: %d\n\n", cadastro[i].estoque);
    }
}
int main() {
    int n;
    printf ("Entre com o número de mercadorias: ");
    scanf ("%d", &n);
    Cadastro *cadastro = malloc(n * sizeof(Cadastro));
    if (cadastro == NULL) {
        printf("Proberlmas de alocação de memoria!\n");
        return 1;
    } else {
        for (int i = 0; i < n; i++) {
            printf ("Entre com o código da mercadoria %d: ",i+1);
            scanf ("%d%*c", &cadastro[i].codigo);
            printf ("Entre com o estoque da mercadoria %d: ", i+1);
            scanf ("%d%*c\n", &cadastro[i].estoque);
        }
    }
    printf ("----------PEDIDOS DOS CLIENTES----------\n\n");
    while (1) {
        printf ("Entre com o código da mercadoria: ");
        int codcli;
        scanf ("%d%*c", &codcli);
        int achou = 0;
        for (int i = 0; i < n; i++) {
            if (cadastro[i].codigo == codcli) {
                printf ("Entre com o estoque da mercadoria: ");
                int estoquecli;
                scanf ("%d", &estoquecli);
                if (cadastro[i].estoque >= estoquecli){
                    cadastro[i].estoque -= estoquecli;
                    printf ("ESTOQUE ATUALIZADO\n");
                } else printf ("ESTOQUE INSUFICIENTE!\n");
                achou = 1;
            }
        }
        if (achou == 0) printf ("MERCADORIA NÃO ENCONTRADA!\n");
        printf ("Deseja enviar outra solicitacao? (Sim: 1/Não: 0): ");
        int escolha;
        scanf ("%d", &escolha);
        if (escolha == 0) break;
    }  
    imprimir(cadastro, n);
    free(cadastro);
}

//https://pt.stackoverflow.com/q/333638/101
