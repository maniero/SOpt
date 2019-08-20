#include <stdio.h>
#include <ctype.h>
#include <string.h>

void truncW (char t[], int n) {
    int s = strlen(t);
   	for (int i = 0, j = 0; i < s; i++, j++) {
    	if (isspace(t[i]) > 0) {
 //   		printf("%d, %d, %d, '%c'", i, j, s, t[i]);
    		j = -1;
    		printf(" ");
    	} else if (j < n) {
    		printf("%c", t[i]);
    	}
    }
}

int main(void) {
   char t[] = "liberdade, igualdade e fraternidade";
   truncW(t, 4);
}

//https://pt.stackoverflow.com/q/54433/101
