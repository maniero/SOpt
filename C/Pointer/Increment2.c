#include <stdio.h>

char *firstblankchar(char *str) {
    while (*str) {
        if (*str == ' ') return str;
        str++;
    }
    return 0;
}

int main() {
	char word[80];
	printf("Digite a string:\n");
	fgets(word, 79, stdin);
	printf("%c", *firstblankchar(word));
}

//https://pt.stackoverflow.com/q/473903/101
