#include <stdio.h>
#include <locale.h>

typedef struct {
    int codigo;
    int tempoativo;
    float potencia;
    float consumonomes;
    char nome[31];
} Equipamento;


void menu(void) {
    printf("---------------------------------------\n");
    printf("| Sessão de cadastro de equipamentos  |\n");
    printf("---------------------------------------\n");
    printf("Digite 1 para cadastrar\n");
    printf("Digite 2 para consultar os cadastros\n");
    printf("Digite 3 para sair\n");
}

void dados(Equipamento *equipamento) {
    printf("Entre com o codigo do equipamento: ");
    scanf("%d", &equipamento->codigo);
}

int main() {
   setlocale(LC_ALL, "Portuguese"); 
   int resp = 0;
   Equipamento equipamento;
   do {
       menu();
       scanf ("%d", &resp);
       switch (resp) {
       case 1:
           dados(&equipamento);
           break;
       case 2:
           break;
       }
       if (resp > 3 || resp < 1) printf("Valor invalido\n");
    } while (resp != 3);
}

//https://pt.stackoverflow.com/q/330759/101
