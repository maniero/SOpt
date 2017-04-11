#include <stdio.h>

int main() {
    printf("Digite seu estado civil: ");
    char est_civil = getchar();
    if (est_civil == 'C' || est_civil == 'c') {
        printf("Casado");
    } else if (est_civil == 'S' || est_civil == 's') {
        printf("Solteiro");
    }
}

//http://pt.stackoverflow.com/q/197550/101
