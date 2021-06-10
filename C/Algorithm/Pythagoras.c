#include <stdio.h>
#include <math.h>

typedef struct {
    int x;
    int y;
} ponto;
int quadradoPontos(int p1, int p2) {
    return pow(p2 - p1, 2);
}
void lePonto(char nome, char coordenada, ponto *p) {
    printf("\nDigite o ponto p%c(%c): ", nome, coordenada);
    if (coordenada == 'X') scanf("%d", &p->x);
    else scanf("%d", &p->y);
}
int main() {
    ponto p1, p2;
    lePonto('1', 'X', &p1);
    lePonto('1', 'Y', &p1);
    lePonto('2', 'X', &p2);
    lePonto('2', 'Y', &p2);
    printf("\nResultado: %.2f", sqrt(quadradoPontos(p1.x, p2.x) + quadradoPontos(p1.y, p2.y)));
}

//https://pt.stackoverflow.com/q/128830/101
