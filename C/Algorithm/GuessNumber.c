#include <stdio.h>

int Calcula(char *sequencia1, char *sequencia2, int pontos) {
	printf("O número está neste grupo?\n");
	printf(sequencia1);
	printf(sequencia2);
	printf("s!\nn!\n");
	char alternativa;
	scanf("%c", &alternativa);
	return alternativa == 's' ? pontos : 0;
}
int main() {
	int soma = 0;
	printf("Pense em um número entre 1 e 63 e aperte <enter>.\n");
	char alternativa;
	scanf("%c", &alternativa);
	soma += Calcula("1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,31,33,\n", "35,37,39,41,43,45,47,49,51,53,55,57,59,61,63\n", 1);
	soma += Calcula("2,3,6,7,10,11,14,15,18,19,22,23,26,27,30,31,34,\n", "35,38,39,42,43,46,47,50,51,54,55,58,59,62,63\n", 2);
	soma += Calcula("4,5,6,7,12,13,14,15,20,21,22,23,28,29,30,31,\n", "37,38,39,44,45,46,47,52,53,54,55,60,61,62,63\n", 4);
	soma += Calcula("8,9,10,11,12,13,14,15,24,25,26,27,28,29,30,31,\n", "40,41,42,43,44,45,46,47,56,57,58,59,60,61,62,63\n", 8);
	soma += Calcula("16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,\n", "48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63\n", 16);
	soma += Calcula("32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,\n", "48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63\n", 32);
	printf ("O número é:%d\n", soma);
}

//https://pt.stackoverflow.com/q/236171/101
