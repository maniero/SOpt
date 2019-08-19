#include <stdio.h>
#include <string.h>

int main() {
    char s[] = "abc";
    char v[] = "cdeabf";
    printf("'%s' %scontém todos os caracteres presentes em '%s'", v, (strspn(s, v) == strlen(s)) ? "" : "não ", s);
}

//https://pt.stackoverflow.com/q/54324/101
