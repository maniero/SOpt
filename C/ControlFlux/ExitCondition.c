#include <stdio.h>
#include <string.h>

int main() {
    char sld[19];
    printf("\t\t ========== Calculadora de Volume ==========");
    while (1) {
        printf("\nDigite o sólido: ");
        fgets(sld, 18, stdin);
        sld[strcspn(sld, "\n")] = 0;
        if (strcmp(sld, "cilindro") == 0) break;
        printf("\nObjeto inválido");
    }
}

//https://pt.stackoverflow.com/q/402720/101
