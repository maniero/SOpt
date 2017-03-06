#include<stdio.h>
#include<ctype.h>

void namechange(char abc[]) {
    for (int i = 0; abc[i] != '\0'; i++) {
        if (i == 0 || abc[i - 1] == ' ') {
            abc[i] = toupper(abc[i]);
        }
    }
    printf("%s", abc);
}

int main() {
    char name[1000];
    scanf("%[^\n]s", name);
    namechange(name);
}

//http://pt.stackoverflow.com/q/188080/101
