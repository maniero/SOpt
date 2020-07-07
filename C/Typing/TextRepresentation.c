#include <stdio.h>

int main() {
	int inteiro = 1;
	float decimal = 6.1f;
	char caractere1 = 'g';
	char *caractere2 = "k";
	printf("O valor inteiro e %i\n", inteiro); // aparece 1 (está ok)
	printf("O valor decimal e %f\n", decimal); // aparece 6.100000 (está ok)
	printf("O caractere1 e %c\n", caractere1); // aparece g (está ok)
	printf("O caractere2 e %c\n\n", caractere2); // aparece d (está errado - com certeza porque coloquei aspas duplas na declaração da variável)
	printf("O valor inteiro e %i\n", &inteiro); // aparece 2293564
	printf("O valor decimal e %f\n", &decimal); // aparece 6.099998
	printf("O caractere1 e %c\n", &caractere1); // aparece 7
	printf("O caractere2 e %c\n\n", &caractere2); // aparece 6
	
	printf("O caractere2 e %s\n", caractere2);
	printf("O valor inteiro (somado para dar algo imprimível) mostrado como caractere e %c\n", inteiro + 64);
	printf("O endereco de decimal e %d\n", &decimal);
	printf("O inicio do caractere2 e %c\n", caractere2[0]);
}

//https://pt.stackoverflow.com/q/266079/101
