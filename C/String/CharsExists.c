#include <stdio.h>

int contem(char s1[], char s2[]) {
    for (int i = 0; s2[i]; i++) {
    	int j;
        for (j = 0; s1[j]; j++) if(s2[i] == s1[j]) break;
        if (s1[j] == '\0') return 0;
    }
    return 1;
}

int main() {
    char s[] = "abc";
    char v[] = "cdeabf";
     if (contem(v, s)) printf("'%s' contém todos os caracteres presentes em '%s'", v, s);
     else printf("'%s' não contém todos os caracteres presentes em '%s'", v, s);
}

//https://pt.stackoverflow.com/q/54324/101
