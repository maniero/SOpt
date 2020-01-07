#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main() {
    char user[20];
    int senha, contador = 0;
    do {
        printf("Entre com o usuario: ");
        scanf("%s", user);
        printf("Entre com a senha: ");
        scanf("%d", &senha);
        // aqui as credenciais estão corretas
        if (!strcmp(user, "leonardo") && senha == 123) {
            printf("\nAcesso concedido.\n");
            break;
        }
        contador++;
    } while (contador < 3);
    if (contador == 3) printf("Limite de tentativas alcancadas.\n");
    printf("Fim.\n");
}

//https://pt.stackoverflow.com/q/126296/101
