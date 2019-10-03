#include <stdio.h>

int main () {
    float nota1[6], nota2[6], nf = 0;
    int nm[6];
    for (int i = 0; i < 6; i++) {
        printf("\nInforme o número de matrícula %d:", i);
        scanf("%d", &nm[i]);
        printf("\nInforme a nota 1 do aluno %d:", i);
        scanf("%f", &nota1[i]);
        printf("\nInforme a nota 2 do aluno %d:", i);
        scanf("%f", &nota2[i]);
    }
    printf("\nMatricula Nota1 Nota2 Nota final\n");
    float notaTotalALunos = 0;
    for (int i = 0; i < 6; i++) {
        nf = (nota1[i] + nota2[i]) / 2;
        notaTotalALunos += nf;
        printf("%d         %2.2f  %2.2f  %2.2f\n", nm[i], nota1[i], nota2[i], nf);
    }
    float medturma = notaTotalALunos / 6;
    printf("A media da turma foi: %2.2f\n", medturma);
    int alunosAbaixoDaMedia = 0;
    for (int i = 0; i < 6; i++) if ((nota1[i] + nota2[i]) / 2 < medturma) alunosAbaixoDaMedia++;
    printf("Notas abaixo da média %d:", alunosAbaixoDaMedia);
}

//https://pt.stackoverflow.com/q/86908/101
