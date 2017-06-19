#include <stdio.h>
#include <string.h>

int main() {
	char s1[20];
	char s2[20];
    printf("Digite uma string : ");
    scanf("%s", s1);
    printf("Digite outra string : ");
    scanf("%s", s2);
    printf("%ld", strstr(s1, s2) - s1);
}

//https://pt.stackoverflow.com/q/213806/101
