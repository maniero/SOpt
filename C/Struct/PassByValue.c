#include <stdio.h>

typedef struct {
    short ano;
    char mes;
    char dia;
} Data;

void print(Data data) {
	printf("%d/%d/%d", data.dia, data.mes, data.ano);
}

int main(void) {
	print((Data){ 2020, 06, 10 });
}

//https://pt.quora.com/As-estruturas-podem-ser-passadas-como-par%C3%A2metros-de-fun%C3%A7%C3%B5es-Justifique-a-sua-resposta
