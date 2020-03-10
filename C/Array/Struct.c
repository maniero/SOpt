#include <stdio.h>
#include <stdlib.h>

typedef struct Atleta {
    float notas[5];
} atleta;
void receberNotas(atleta* l) {
    for (int i = 0; i < 5; i++) {
        printf("Digite %d nota: ", (i + 1));
        scanf("%f", &l->notas[i]);
    }
}
void mostrarNotas(atleta *l) {
    for (int i = 0; i < 5; i++) printf("\n%.2f", l->notas[i]);
}
int main() {
    atleta *a = malloc(sizeof(atleta));
    receberNotas(a);
    mostrarNotas(a);
}

//https://pt.stackoverflow.com/q/155355/101
