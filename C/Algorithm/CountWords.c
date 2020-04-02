#include<stdio.h>
#include<string.h>

int main() {
    char str[50];
    printf(" We will count the number of letters\n");
    printf("-------------------------------------\n");
    printf("Tell me the word: \n");
    scanf("%s", str);
    int i;
    for (i= 0; str[i] != '\0'; i++) printf("The letter %d is %c\n", i, str[i]);
    printf("|The number of words is: %d\n", i);
}

//https://pt.stackoverflow.com/q/172952/101
