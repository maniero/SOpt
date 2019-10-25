#include<stdio.h>
#include<string.h>

int main() {
	char times[20][15] = {"Corinthians", "Atlético-MG", "Grêmio", "Santos", "São Paulo", "Internacional", "Sport", "Palmeiras", "Ponte Preta", "Flamengo",
	"Cruzeiro", "Atlético-PR", "Fluminense", "Chapecoense", "Figueirense", "Havaí", "Coritiba", "Goias", "Joinville" ,"Vasco da Gama"};
	int pontos[20] = {70, 62, 56, 50, 50, 50, 49, 48, 47, 44, 44, 42, 40, 39, 35, 34, 33, 31, 30, 30};
	int menu = 0;
	//Entrada de dados
	while (menu > 0 && menu < 3) {
   		int opcao, realpos = 0;
	    switch (menu) {
	    case 1: printf("+----BRASILEIRAO 2015---+");
	        for (int i = 0; i < 20; i++) printf("%d -  %s - %d", i + 1, times[i], pontos[i]);
	        printf("+----FIM---+");
	        menu = 666;
	        break;
	    case 2:
	        printf("Digite o a posição do time que deseja simular");
	        scanf("%d", &opcao);
	        for (int i = 1; i <= 8; i++) {
		        realpos = opcao - 1;
		        printf("Digite o resultado do %dº jogo do %s. (V, E ou D)", i, times[realpos]);
		        char jogo;
		        scanf("%c", &jogo);
		        switch (jogo) {
		            case 'V':
			            pontos[realpos] += 3;
			            break;
		            case 'E':
			            pontos[realpos]++;
			            break;
		            case 'D':
			            break;
		            default:
			            printf("Digite o resultado do %dº jogo do %s. V, E ou D)", i, times[realpos]);
			            scanf("%c", &jogo);
			            break;
		        }
	        }
	        for (int i = 0; i < 20; i++) printf("%d -  %s  -  %d", (i+1), times[i], pontos[i]);
	        break;
	    }
	    printf("Digite 0 para sair");
	    scanf("%d", &menu);
    }
}

//https://pt.stackoverflow.com/q/97313/101
