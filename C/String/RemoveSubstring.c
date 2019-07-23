#include<stdio.h>

void StrlDel(char *s1, char *s2) {
    int i = 0;
    int notFound = 1;
    while (s1[i]) {
    	int j;
        for (j = 0; s2[j] && s2[j] == s1[i + j]; j++);
        if (!s2[j] && notFound) {
        	int k;
            for (k = i; s1[k + j]; k++) s1[k] = s1[k + j];
            s1[k] = 0;
            notFound = 0;
        } else i++;
    }
}

int main(void) {
    char palavras[] = "O rato roeu a rolha da garrafa";
    StrlDel(palavras, "ra");
    printf("\n%s\n", palavras);
}
 
//https://pt.stackoverflow.com/q/398277/101
