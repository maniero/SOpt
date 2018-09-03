#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

typedef struct {
    int matricula;
    float salario;
} Funcionario;

int ler_dados(void) {
    int dado;
    printf("Digite a matrícula:\t");
    scanf(" %d", &dado);
    return dado; 
}
float ler_salario(void) {
      float salario;
      printf("Digite o valor do salário:\t");
      scanf(" %f", &salario);
      return salario;
}
int inserir_funcionario(Funcionario **funcionarios, int tamanho) {
    *funcionarios = realloc(*funcionarios, sizeof(Funcionario) * (tamanho + 1));
    (*funcionarios)[tamanho].matricula = ler_dados();
    (*funcionarios)[tamanho].salario = ler_salario();
    return ++tamanho;
}
int main(void) {
    setlocale(LC_ALL,"Portuguese");
    Funcionario *funcionarios = malloc(sizeof(Funcionario));
    int tamanho = 0;
    for (int i = 0; i < 5; i++) {
        printf("Sizeof : %lu\n", sizeof(Funcionario));
        printf("Executou: %d\n", i + 1);
        printf("Tamanho: %d\n\n", tamanho);
        tamanho = inserir_funcionario(&funcionarios, tamanho);
        printf("\ndado: %d\n\n", funcionarios[tamanho].matricula);
    }
}

//https://pt.stackoverflow.com/q/326686/101
