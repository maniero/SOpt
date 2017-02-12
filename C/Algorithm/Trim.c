#include <stdio.h>

void rSpace(char *string) {
	int j = 0;
	char last = '\0';
    for (int i = 0; string[i] != '\0'; i++) {
        if (string[i] != ' ' || last != ' ') {
            string[j] = string[i];
            j++;
       	    last = string[i];
        }
    }
   string[j] = '\0';
}

int main() {
    char frase2[200] = "minha   frase com   algums     espaços";
    rSpace(frase2);
    printf("%s\n", frase2);
}

//http://pt.stackoverflow.com/q/183633/101
