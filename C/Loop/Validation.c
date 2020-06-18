#include <stdio.h>
#include <locale.h>

int main(void) {
	setlocale(LC_ALL,"Portuguese");
	struct Aluno {
	    char nome[10];
	    float notaMath, notaPhysics, media;
	} aluno[5];
	for (int contador = 0; contador < 5; contador++) {
	    printf("Nome do aluno %d: ", contador + 1);
	    scanf("%s", aluno[contador].nome);
	    while (1) {
		    printf("Nota de matemática: ");
		    scanf("%f", &aluno[contador].notaMath);
		    if (aluno[contador].notaMath > 10.0) printf("Apenas notas até 10.\n");
		    else break;
	    }
		while (1) {
		    printf("Nota de física: ");
		    scanf("%f", &aluno[contador].notaPhysics);
		    if (aluno[contador].notaPhysics > 10.0) printf("Apenas notas até 10.\n");
		    else break;
		}
	    aluno[contador].media = (aluno[contador].notaMath + aluno[contador].notaPhysics) / 2;
	    printf("\n");
	}
	printf("\n\n------------Informações dos Alunos------------\n");
	for (int contador = 0; contador < 5; contador++) {
	    printf("Nome do aluno %d: %s\n", contador+1, aluno[contador].nome);
	    printf("Nota de matemática: %.1f\n", aluno[contador].notaMath);
	    printf("Nota de física: %.1f\n", aluno[contador].notaPhysics);
	    printf("Média das notas: %.1f\n", aluno[contador].media);
	    printf("\n\n");
	}
}

//https://pt.stackoverflow.com/q/241369/101
