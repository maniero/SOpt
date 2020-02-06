#include <stdio.h>
#include <ctype.h>
#define MAX 5

int comparacao(char s1[], char s2[], int n) {
	int i = 0;
    for (; i < n && tolower(s1[i]) == tolower(s2[i]); i++);
    return i == n;
}

int main() {
    char s1_m[MAX] = {'a', 'b', 'c', 'd', 'e'}, s2_m[MAX] = {'a', 'b', 'c', 'D', 'E'};
    int n_m;
    printf("quantos caracteres serao verificados(max 5)\n> "); scanf("%d", &n_m);
    printf("os %d primeiros caracteres dos dois vetores %ssao iguais", n_m, comparacao(s1_m, s2_m, n_m) ? "" : "nao ");
}

//https://pt.stackoverflow.com/q/139712/101
