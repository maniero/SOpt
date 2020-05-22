#include <stdio.h>

int main() {
    char consoante[10];
    int total = 0;
    char c;
    for (int i = 0; i < 10; i++) {
        printf("Digite a letra: ");
        char letra;
        scanf("%c", &letra);
        while ((c = getchar()) != '\n' && c != EOF) { }
        if (letra != 'a' && letra != 'e' && letra != 'i' && letra != 'o' && letra != 'u') consoante[total++] = letra;
    }
    printf("\n%d", total);
    for (int i = 0; i < total; i++) printf("\nA consoante foi: %c", consoante[i]);
}

//https://pt.stackoverflow.com/q/453291/101
