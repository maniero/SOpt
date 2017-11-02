#include <stdio.h>
#include <ctype.h>
 
int stricmp(char const *s1, char const *s2) {
   while (1) {
        int res = tolower(*s1) - tolower(*s2);
        if (res != 0 || !*s1) return res;
        s1++;
        s2++;
    }
}
 
int main(void) {
	printf("%d\n", stricmp("aaa", "AAA"));
	printf("%d\n", stricmp("aaa", "aaa"));
	printf("%d\n", stricmp("aaa", "AAB"));
	printf("%d\n", stricmp("abb", "AAB"));
}

//https://pt.stackoverflow.com/q/251861/101
