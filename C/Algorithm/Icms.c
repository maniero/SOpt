#include <stdio.h>

#define MVAIN  0.8592f
#define MVAOUT 1.0282f
#define ICMS 0.29f

int main(){
    printf("Indique o valor dos produtos da nfe que contenham ST\n");
	float ProdValue = 0;
    scanf("%f", &ProdValue);   
    printf("O valor dos produtos é: %0.2f\n", ProdValue);
    printf("Informe se o MVA é fora ou dentro do estado\n");
	int MVA = 0;
    scanf("%d", &MVA);
    float ValorMVA = ProdValue * (MVA == 2 ? MVAOUT : MVAIN);
    printf ("O valor do MVA é %0.2f\n", ValorMVA);
	float ValorComMVA = ProdValue + ValorMVA;
    printf ("O valor total é %0.2f\n", ValorComMVA);
	float ValorIcms = ValorComMVA * ICMS;
    printf ("O valor do ICMS é %0.2f\n", ValorIcms);
	float Diferenca = ValorMVA - ValorIcms;
    printf ("O valor a recolher é %0.2f\n", Diferenca);
}

//http://pt.stackoverflow.com/q/191144/101
