#include<stdio.h>

int main() {
    while (1) {
    	float vi, vf;
        printf("\n#############################");
        printf("\nValor Inicial: "); scanf("%f", &vi);
        printf("\nValor Final: "); scanf("%f", &vf);
        int o = (vi <= vf) ? 1 : -1;
        for (int i = vi; i != vf + o; i += o) printf("\n %d", i);
        char continuar;
        printf("\nDigite F para encerrar: "); scanf("%c", &continuar);
		if (continuar == 'F') break;
    }
}

//https://pt.stackoverflow.com/q/386314/101
