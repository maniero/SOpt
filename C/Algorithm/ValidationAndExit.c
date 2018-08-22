#include <stdio.h>

int main(void) {
    int media = 0;
    while (media != -1)  {
        printf("Digite a media do final aluno: \n");
        scanf("%d", &media);
        if (media < -1 || media > 10) {
            printf("Voce digitou numero invalido ");
            continue;
        }
        printf(media >= 7 ? "APROVADO!\n" : "REPROVADO!\n");
    }
    printf("Fim do programa! \n"); // quando eu digito -1
}

//https://pt.stackoverflow.com/q/324231/101
