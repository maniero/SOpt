#include <stdio.h>
#include <string.h>
 
int main(void) {
    char str1[15], str2[15];
    printf("Digite uma palavra de ate 10 letras: ");
    fgets(str1, 15, stdin);
    printf("Digite outra palavra de ate 10 letras: ");
    fgets(str2, 15, stdin);
    int size_str1 = strlen(str1)-1;
    int size_str2 = strlen(str2)-1;
    for (int i = 0; i < size_str1; i++) {
        for (int j = 0; j < size_str2; j++) {
            if (str1[i] == str2[j]) {
                for (int k = i; k < size_str1; k++) {
                	str1[k] = str1[k + 1];
                }
            }
        }
    }
    puts(str1);
}

//https://pt.stackoverflow.com/q/32355/101
