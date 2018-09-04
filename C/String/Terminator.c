#include <stdio.h>

int main(void) {
    char nomeSobrenome[40] = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
    printf("Insira seu nome e seu sobrenome:\n");
    scanf("%[A-Z a-z 0-9 !-_]s", nomeSobrenome);
    printf("%s\n", nomeSobrenome);
    for (int i = 0; i < 40; i++) printf("%c = %d\n", nomeSobrenome[i], nomeSobrenome[i]);
}

//https://pt.stackoverflow.com/q/327101/101
