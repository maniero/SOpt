#include<stdio.h>

int main(void) {
	int n;
	printf("Quantas vezes o programa deve ser executado:");
	scanf("%d", &n);
	for (int i = 1; i <= n; i++) {
		int d1;
		printf("Numero de dias 1:");
		scanf("%d", &d1);
		int d2;
		printf("Numero de dias 2:");
		scanf("%d", &d2);
		int h1;
		printf("Numero de horas 1:");
		scanf("%d", &h1);
		int h2;
		printf("Numero de horas 2:");
		scanf("%d", &h2);
		int m1;
		printf("Numero de minutos 1:");
		scanf("%d", &m1);
		int m2;
		printf("Numero de minutos 2:");
		scanf("%d", &m2);
		int dias = d1 + d2;
		int horas = h1 + h2;
		int minutos = m1 + m2;
		horas += minutos / 60;
		minutos %= 60;
		dias += horas / 24;
		horas %= 24;
		printf("%2u Dias %2u Horas %2u Minutos mais\n", d1, h1, m1);
		printf("%2u Dias %2u Horas %2u Minutos\n", d2, h2, m2);
		printf("eh igual a %2u Dias %2u Horas %2u Minutos\n\n", dias, horas, minutos);
	}
}

//https://pt.stackoverflow.com/q/133429/101
