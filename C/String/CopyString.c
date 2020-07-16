#include <stdio.h>
#include <string.h>

void menu_principal(char *monstro1, char* monstro2){
    printf("King of Tokyo\n\n");
    printf("Jogador escolha um monstro:\n---------------------------\n");
    printf("1-Godzilla\n2-Feto Gigante Zumbi Nazista\n3-Pac-Man\n4-Blanca\n5-Penha\n6-Nemesis\n\n0-SAIR\n\n");
    int escolha;
    do { scanf("%d", &escolha); } while (escolha < 0 || escolha > 6);
    if (escolha == 0) exit(0);
    char *monstros[] = { "", "Godzilla", "Feto Gigante Zumbi Nazista", "Pac-Man", "Blanca", "Penha", "Nemesis" };
    strcpy(monstro1, monstros[escolha]);
    printf("VOCE ESCOLHEU: %s\n\n", monstro1);
}

int main(){
    char monstromain1[30]=".";
    char monstromain2[30]="..";
    menu_principal(monstromain1, monstromain2);
    printf("%s", monstromain1);
}

//https://pt.stackoverflow.com/q/290674/101
