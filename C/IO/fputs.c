#include <stdio.h>

int main(void) {
    FILE *fp;
    char s[100];
    fp = fopen("datafile.txt", "w");
    while(fgets(s, sizeof(s), stdin) != NULL) { //o fgets está lendo do console (stdin)
        fputs(s, fp);  // escreve no arquivo
        puts(s); //escreve no console
    }
    fclose(fp);
    return 0;
}

//https://pt.stackoverflow.com/q/32329/101
