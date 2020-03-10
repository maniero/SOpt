#include<stdio.h>
#include<string.h>
#include<stdlib.h>

int Norte(char cacapalavra[][100], char palavra[], int *pc, int *pl) {
    int i, j, n, k;
    j = *pc; k = 0;
    n = strlen(palavra);
    for (i = *pl; i < i + n; i++) {
        if (cacapalavra[i][j] != palavra[k]) return -1;
        else k++;
    }
    *pl = i;
    return 0;
}

int Sul(char cacapalavra[][100], char palavra[], int *pc, int *pl) {
    int i, j, n, k;
    j = *pc; k = 0;
    n = strlen(palavra);
    for (i = *pl; i < i + n; i++) {
        if (cacapalavra[i][j] != palavra[k]) return -1;
        else k++;
    }
    *pl = i;
    return 0;
}

int Leste(char cacapalavra[][100], char palavra[], int *pc, int *pl) {
    int i, j, n, k;
    i = *pl; k = 0;
    n = strlen(palavra);
    for (j = *pc; j < j + n; j++) {
        if (cacapalavra[i][j] != palavra[k]) return -1;
        else k++;
    }
    *pc = j;
    return 0;
}

int Oeste(char cacapalavra[][100], char palavra[], int *pc, int *pl) {
    int i, j, n, k;
    i = *pl; k = 0;
    n = strlen(palavra);
    for (j = *pc; j < j + n; j--) {
        if (cacapalavra[i][j] != palavra[k]) return -1;
        else k++;
    }
    *pc = j;
    return 0;
}

int Nordeste(char cacapalavra[][100], char palavra[], int *pc, int *pl) {
    int i, j, n, k;
    k = 0;
    n = strlen(palavra);
    for (i = *pl, j = *pc; i < i + n; j++, i--) {
        if (cacapalavra[i][j] != palavra[k]) return -1;
        else k++;
     }
     *pl = i; *pc = j;
     return 0;
}

int Noroeste(char cacapalavra[][100], char palavra[], int *pc, int *pl) {
     int i, j, n, k;
     k = 0;
     n = strlen(palavra);
     for (i = *pl, j = *pc; i < i + n; j--, i--) {
        if (cacapalavra[i][j] != palavra[k]) return -1;
        else k++;
     }
     *pl = i; *pc = j;
     return 0;
}

int Sudeste(char cacapalavra[][100], char palavra[], int *pc, int *pl) {
    int i, j, n, k;
    k = 0;
    n = strlen(palavra);
    for (i = *pl, j = *pc; i < i + n; j--, i++) {
        if (cacapalavra[i][j] != palavra[k]) return -1;
        else k++;
    }
    *pl = i; *pc = j;
    return 0;
}

int Sudoeste(char cacapalavra[][100], char palavra[], int *pc, int *pl) {
    int i, j, n, k;
    k = 0;
    n = strlen(palavra);
    for (i = *pl, j = *pc; i < i + n; j++, i++) {
        if (cacapalavra[i][j] != palavra[k]) return -1;
        else k++;
    }
    *pl = i; *pc = j;
    return 0;
}

int main () {
    char cacapalavra [100][100];
    char palavra [100];
    int k = 0, n, *pc = 0, *pl = 0, aux;
    scanf ("%d", &n);
    for (int i = 0; i < n; i++) for (int j = 0; j < n; j++) scanf("%c", &cacapalavra[i][j]);
    scanf ("%s", palavra);
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            if (palavra[k] == cacapalavra[i][j]) {
                *pc = j; *pl = i;
                aux = Norte(cacapalavra, palavra, pc, pl);
                aux = Sul(cacapalavra, palavra, pc, pl);
                aux = Leste(cacapalavra, palavra, pc, pl);
                aux = Oeste(cacapalavra, palavra, pc, pl);
                aux = Nordeste(cacapalavra, palavra, pc, pl);
                aux = Noroeste(cacapalavra, palavra, pc, pl);
                aux = Sudeste(cacapalavra, palavra, pc, pl);
                aux = Sudoeste(cacapalavra, palavra, pc, pl);
                printf("%d", aux); //só para eliminar o warning que não foi usada.
            }
        }
    }
}

//https://pt.stackoverflow.com/q/155345/101
