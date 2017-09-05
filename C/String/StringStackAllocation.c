#include <stdio.h>

int main(){
    char str[3][30];
    printf("DIGITE QUALQUER STRING: ");
    scanf("%s", str[0]);
    printf("%s\n", str[0]);
    printf("DIGITE OUTRA STRING: ");
    scanf("%s", str[1]);
    printf("%s\n", str[1]);
    printf("DIGITE MAIS OUTRA: ");
    scanf("%s", str[2]);
    printf("%s\n", str[2]);
}

//https://pt.stackoverflow.com/q/235086/101
