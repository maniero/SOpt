#include <stdio.h>
#include <string.h>

int main() {
    char ch[4];
    strcpy(ch, "abc");
    printf("ch tem %d bytes\n", sizeof(ch));
    printf("ch conta com %d caracteres\n", strlen(ch));
    strcpy(ch, "texto longo");
    printf("ch conta com %d caracteres\n", strlen(ch));
}

//https://pt.stackoverflow.com/q/155932/101
