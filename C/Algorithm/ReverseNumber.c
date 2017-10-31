#include <stdio.h>
#include <string.h>

void reverse(char str[]) {
    int len = strlen(str) ;
    char tmp;
    for (int i = len / 2; i >= 0; i--) {
        tmp = str[i];
        str[i] = str[len - i - 1];
        str[len - i - 1] = tmp;
    }
}

int main(void) {
	char str[] = "123";
	reverse(str);
	printf("%s", str);
}

//https://pt.stackoverflow.com/q/37031/101
