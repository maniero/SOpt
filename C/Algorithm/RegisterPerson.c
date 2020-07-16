#include <stdio.h>

int main() {
    float alturas = 0.0f;
    int contador = 0, masculinos = 0, femininos = 0;
    printf("Cálculo de alunos e alunas e média de suas alturas\n");
    while (contador < 3) {
        float altura;
        char gen;
        printf("Digite a altura e o sexo do aluno\n");
        scanf("%f", &altura);
        scanf("%s", &gen);
        if (gen == 'm' || gen == 'M') masculinos++;
        else if (gen == 'f' || gen == 'F') femininos++;
        else continue;
        alturas += altura;
        contador++;
    }
    printf("A média de altura dos alunos é: %f\n", alturas / contador);
    printf("Temos %d alunos homens e %d alunos mulheres\n", masculinos, femininos);
}

//https://pt.stackoverflow.com/q/289868/101
