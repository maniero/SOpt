#include <iostream>
using namespace std;

int main() {
	int vetor[10], i;
	char op;
	do {
		float res = 0;
		for (i = 0; i <= 9; i++) {
		    printf("\nInforme um numero: ");
		    scanf("%i", &vetor[i]);
//		    printf("%i", vetor[i]);
		    if (vetor[i] % 2 == 0) {
		        res += vetor[i];
		    }
		}
		printf("\nA soma dos pares e: %.2f", res);
		printf("\nDeseja calcular novamente? ");
		scanf("%s", &op);
		fflush(stdin);
	} while (op == 's' || op == 'S');
}

//https://pt.stackoverflow.com/q/86530/101
