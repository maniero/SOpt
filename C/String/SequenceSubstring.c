#include <stdio.h>
#include <string.h>

int main(void) {
	char str[6] = "UTFPR";
	for (int j = strlen(str); j >= 0; j--) {
		for (int i = 0; i < j; i++) {
			str[j] = '\0';
		    printf("%s\n", str + i);
		}
	}
}

//https://pt.stackoverflow.com/q/323222/101
