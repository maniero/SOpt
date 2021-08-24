#include <stdio.h>

void stringToUpper(char str[]) {
    for (int i = 0; str[i] != '\0'; i++) printf("%c", str[i] - ((str[i] >= 'a' && str[i] <= 'z') ? 32 : 0));
}

int main(){
    stringToUpper("All your BASE are Belong to US!");
}

//https://pt.stackoverflow.com/q/523944/101
