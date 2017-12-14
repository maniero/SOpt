#include <stdio.h>

void ImprimeMenu(char *menuOpc[], size_t length) {
    for (int i = 0; i < length; i++) printf("%i - %s\n", i + 1, menuOpc[i]);
}

int main(void) {
	char *opcSalgados[] = { "Pastel", "Mini pizza", "Coxinha", "Pao de queijo", "Pao de frango com queijo", "Pao de carne" };
    ImprimeMenu(opcSalgados, sizeof(opcSalgados) / sizeof(opcSalgados[0]));
}

//https://pt.stackoverflow.com/q/262990/101
