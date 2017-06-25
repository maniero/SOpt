#include <stdio.h>
#include <stdlib.h>

int main(void) {
    int i;
    printf("\nDigite a quantidade de numeros que serao digitados: ");
    scanf ("%d", &i);
    int *p = malloc(i * sizeof(int));
    if (p == NULL) {
        printf ("\nERRO.MEMORIA INSUFICIENTE");
        exit(1);
    }
    for (int k = 0; k < i; k++) {
        printf ("\nDigite o % do valor do vetor: ", k + 1);
        scanf ("%d", &p[k]);
    }
    printf("\n\n========== VETOR PREENCHIDO ==========\n");
    for (int k = 0; k < i; k++) printf ("%d\t", p[k]);
    printf("\n\nSeu vetor possui %d elementos.", i);
    printf("\nDigite um valor positivo para aumentar ao vetor.");
    printf("\nDigite um valor negativo para diminuir do vetor.\n\n");
    int n;
    scanf("%d", &n);
    if (!(i + n)) {
        printf("\nSeu vetor possui 0 elementos.\n\n");
        exit(1);
    } else if ((i + n) < 0) {
        printf("\nSeu vetor possui quantidade negativa de elemento.\n\nIMPOSSIVEL ALOCAR MEMORIA.\n\n");
        exit(1);
    }
    p = realloc(p, (i + n) * sizeof(int));
    if (p == NULL) {
        printf("\nERRO DE RE-ALOCACAO.MEMORIA INSUFICIENTE");
        exit(1);
    }
    for (int k = i; k < (n + i); k++) { //<==================== o erro estava aqui
        printf("\nDigite o % do valor do vetor: ",k+1);
        scanf("%d", &p[k]);
    }
    printf("\n\n========== VETOR PREENCHIDO REALOCADO ==========\n");
    for (int k = 0; k < (n+i); k++) {
        printf("%d\t", p[k]);
    }
    free(p); //na prática não é necessário aqui porque o programa vai encerrar, mas pra fins de aprendizado ok
}

//https://pt.stackoverflow.com/q/215422/101
