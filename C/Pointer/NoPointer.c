#include <stdio.h>
#include <stdlib.h>

typedef struct {
    char *nome;
    char *email;
    int idade;
} Funcionario;

int main() {
    int opcao, qtdeFuncionarios;
    printf("1.Cadastrar funcionario\n");
    printf("2.Listar funcionarios\n");
    printf("3.Editar dados de funcionario\n");
    printf("4.Excluir funcionario\n");
    scanf("%d", &opcao);
    if (opcao == 1) {
        printf("Quantos funcionarios deseja cadastrar? ");
        scanf("%d", &qtdeFuncionarios);
        Funcionario *funcionarios = malloc(qtdeFuncionarios * sizeof(Funcionario));
        for (int i = 0; i < qtdeFuncionarios; i++) {  
            funcionarios[i].nome = malloc(35);
            printf("\nDigite o nome do funcionario %d: ", i);
            scanf("%34s", funcionarios[i].nome);
            printf("\n%s", funcionarios[i].nome);
            funcionarios[i].email = malloc(35);
            printf("\nDigite o email do funcionario %d: ", i);
            scanf("%34s", funcionarios[i].email);
            printf("\n%s", funcionarios[i].email);
            printf("\nDigite a idade do funcionario %d: ", i);
            scanf("%d", &funcionarios[i].idade);
            printf("\n%d", funcionarios[i].idade);
        }
    }
}

//https://pt.stackoverflow.com/q/410784/101
