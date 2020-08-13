#include <stdio.h>
#include <locale.h>

#define N 51

int main() {
    setlocale(LC_ALL,"portuguese");
    char cmaior, cmenor;
    char v[N];
    int contMaior = 1, contMenor = 1, maior = 1, menor = N;
    printf("\nDigite a string: ");
    scanf("%s", v);
    for (int i = 0; v[i] != '\0'; i++) {
        if (v[i] == v[i + 1]) {
            contMaior++;
            contMenor++;
        } else {
            contMaior = 1;
            contMenor = N;
        }
        if (contMaior > maior) {
            maior = contMaior;
            cmaior = v[i];
        }
        if (contMenor < menor) {
            menor = contMenor;
            cmenor = v[i];
        }
    }
    printf("\n Maior: %c, tamanho %d; Menor: %c, tamanho %d\n", cmaior, maior, cmenor, menor);
}

//https://pt.stackoverflow.com/q/340613/101
