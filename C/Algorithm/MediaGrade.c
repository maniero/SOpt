#include <stdio.h>
int main() {    
	char nome[30];
	int f = 0;
	printf("Digite o nome do aluno: ");
	scanf("%s", nome);
	printf("\nDigite o numero de faltas do aluno: ");
	scanf("%d", &f);
	if (f > 15) {
	    printf("\nAluno reprovado por falta.");
	} else {
	    float n1, n2, n3;
	    printf("\nDigite a primeira nota do aluno: ");
	    scanf("%f", &n1);
	    printf("\nDigite a segunda nota do aluno: ");
	    scanf("%f", &n2);
	    printf("\nDigite a terceira nota do aluno: ");
	    scanf("%f", &n3);
	    float mf = (n1 + n2 + n3) / 3;
	    if (mf >= 7) {
	        printf("\nAluno aprovado!");
	    } else {
	        printf("\nAluno reprovado por media.");
	    }
	}
}

//http://pt.stackoverflow.com/q/186671/101
