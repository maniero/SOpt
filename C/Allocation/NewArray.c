#include <stdio.h>
#include <stdlib.h>

typedef struct {
    int dia;
    int mes;
    int ano;
} Data;
 
Data *imprime_data(Data *datas, int n, int k, int *total) {
	Data *teste = malloc(n * sizeof(Data));
	*total = 0;
	for (int i = 0; i < n; i++) {
        if (datas[i].dia % 10 <= k && datas[i].mes % 10 <= k && datas[i].ano % 10 <= k) {
        	teste[i] = datas[i];
        	(*total)++;
        }
	}
	return teste;
}

int main() {
	int n;
	scanf ("%d", &n);
	Data *datas = malloc(n * sizeof(Data));
	for (int i = 0; i < n; i++) scanf("%d %d %d", &datas[i].dia, &datas[i].mes, &datas[i].ano); 
	int k;
	scanf("%d", &k);
	int total = 0;
	Data *teste = imprime_data(datas, n, k, &total);
	for (int i = 0; i < total; i++) printf("%d %d %d", teste[i].dia, teste[i].mes, teste[i].ano);
	free(datas);
	free(teste);
}

//https://pt.stackoverflow.com/q/463111/101
