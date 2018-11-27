#include <stdio.h>

void escolha_simb(char *jog1, char *jog2) {
    while (1) {
        printf("\njogador 1, escolha X ou O \n");
        char esc;
        scanf("%c", &esc);
        if (esc == 'x') {
            *jog2 = 'X';
            *jog1 = 'O';
            break;
        }
        else if (esc == 'o') {
            *jog2 = 'O';
            *jog1 = 'X';
            break;
        }
    }
}

int main() {
    char jog1 = 0, jog2 = 0;
    printf("jog1: %c jog2: %c", jog1, jog2);
    escolha_simb(&jog1, &jog2);
    printf("depois\njog1: %c jog2: %c", jog1, jog2);
}

//https://pt.stackoverflow.com/q/346035/101
