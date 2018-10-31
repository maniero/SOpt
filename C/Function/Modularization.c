#include <stdio.h>

int Inverte(int n) {
	int l = 0, j;
	while (n != 0) {
	    j = n % 10;
	    l = (l * 10) + j;
	    n /= 10;
	}
	return l;
}
int main(void) {
	int i;
	scanf("%d", &i);
	printf(i == Inverte(i) ? "sim" : "nao");
}

//https://pt.stackoverflow.com/q/340095/101
