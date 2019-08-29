#include <stdio.h>
#include <math.h>

int main (void) {
	int hip, cat1, cat2;
	scanf("%d", &cat1);
	scanf("%d", &cat2);
	scanf("%d", &hip);
	if (hip == (int)sqrt(pow(cat1, 2) + pow(cat2, 2))) printf("SIM");
	else printf("NAO");
}

//https://pt.stackoverflow.com/q/56916/101
