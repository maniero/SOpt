#include <stdio.h>
#include <ctype.h>

int main(){
    char texto[30];
    printf("Pressione A B C para 2");
    printf("\nPressione D E F para 3");
    printf("\nPressione G H I para 4");
    printf("\nPressione J K L para 5");
    printf("\nPressione M N O para 6");
    printf("\nPressione P Q R S para 7");
    printf("\nPressione T U V para 8");
    printf("\nPressione W X Y Z para 9");
    printf("\n\nInforme as letras: ");
    scanf("%s", texto);
    for (int i = 0; texto[i] != '\0'; i++) {
    	char letra = toupper(texto[i]);
        if (letra == 'A' || texto[i] == 'B' || letra == 'C') printf("2");
        else if (letra == 'D' || letra == 'E' || letra == 'F') printf("3");
        else if (letra == 'G' || letra == 'H' || letra == 'I') printf("4");
        else if (letra == 'J' || letra == 'K' || letra == 'L') printf("5");
        else if (letra == 'M' || letra == 'N' || letra == 'O') printf("6");
        else if (letra == 'P' || letra == 'Q' || letra == 'R' || letra == 'S') printf("7");
        else if (letra == 'T' || letra == 'U' || letra == 'V') printf("8");
        else if (letra == 'W' || letra == 'X' || letra == 'Y' || letra == 'Z') printf("9");
        else printf("%c", texto[i]);
    }
}

//https://pt.stackoverflow.com/q/341033/101
