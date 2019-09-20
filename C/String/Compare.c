#include <stdio.h>
#include <string.h>

int main(void) {
char b[8], a[8];
strcpy(a, "banana");
strcpy(b, "abacate");
if (a < b) printf ("%s vem antes de %s no dicionário", a, b);
else printf ("%s vem depois de %s no dicionário", a, b);
/*
char *b, *a;
a = "abacate";
b = "banana";
if (a < b) printf ("%s vem antes de %s no dicionário", a, b);
else printf ("%s vem depois de %s no dicionário", a, b);
char *a, *b;
a = "abacate";
b = "amora";
if (*a < *b) printf ("%s vem antes de %s no dicionário", a, b);
else printf ("%s vem depois de %s no dicionário", a, b);
*/
}

//https://pt.stackoverflow.com/q/80074/101
