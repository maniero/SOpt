#include <stdio.h>

typedef struct {
    int codigo;
    char obra[30]; 
    char autor[30]; 
    char editora[30];
} Livro;

int main() {
    int codigo = 0;
    Livro livro[5];
    int op = 1;
    while (op != 0) {
        printf("\nMENU.\n"
        "1 - Inserir um novo cadastro.\n"
        "2 - Mostrar todos os cadastros.\n"
        "0 - Encerrar.\n");
	    printf("\nEscolha sua opcao:");
	    scanf("%d", &op);
	    int c; //para limpar buffer
	    while ((c = getchar()) != '\n' && c != EOF) { }
	    switch (op) {
	    case 1:
	        if (codigo < 5) {
	            printf("\nNovo cadastro.\n");
	            printf("Codigo:%d \n", codigo);
	            printf("Insira o nome do livro: \n");
	            fgets(livro[codigo].obra, 30, stdin);
	            printf("Insira o nome do autor: \n");
	            fgets(livro[codigo].autor, 30, stdin);
	            printf("Insira o nome da editora: \n");
	            fgets(livro[codigo].editora, 30, stdin);
	            codigo++;
	        } else printf("\nSistema de cadastro lotado.\n");
	    break;
	    case 2:
	        if (codigo == 0) printf("\nA lista esta vazia!\n");
	        else {
	            printf("\nCadastros.\n");
	            for (int i = 0 ; i < codigo; i++) {
	                printf("\nCodigo:%d ", i);
	                printf("\nNome do livro: %s", livro[i].obra);
	                printf("Nome do autor: %s", livro[i].autor);
	                printf("Nome da editora: %s", livro[i].editora);
	            }
	        }
	    break;
	    case 0:
	        printf("Encerrando o programa.\n");
	        break;
	    default:
	        printf("Opcao invalida!");
	    break;
	    }
	}
}

//https://pt.stackoverflow.com/q/393054/101
