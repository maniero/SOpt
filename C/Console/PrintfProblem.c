#include <stdio.h>
#include <stdlib.h>
int main(void) {
    int alunos[10];
    for (int i = 0; i < 10; i++) {
        printf("insira a idade do aluno %d", i + 1);
        scanf("%d", &alunos[i]);
        printf("\n");
    }
    for (int i = 0; i < 10; i++) {
        printf("%d\n", alunos[i]);
    }
    return (EXIT_SUCCESS);
}

//http://pt.stackoverflow.com/q/182035/101
