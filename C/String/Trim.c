#include <stdio.h>

void removerSpacos(char str[]) {
	int j = 1;
	for (int i = 1; str[i]; i++) {
        if (str[i] != ' ' || (str[i - 1] != ' ')) {
           str[j] = str[i];
           j++;
        }
	}
    str[j] = '\0';
}
int main() {
   char frase[] = "Ola Mundo!";
   removerSpacos(frase);
   printf("%s", frase);
   return 0;
}

//http://pt.stackoverflow.com/q/120141/101
