#include <stdio.h>

int main (void) {
	int A, B, C;
	scanf("%d %d %d", &A, &B, &C);
	if (A < B && B < C) printf("%d %d %d", A, B, C);
	else if (C < B && B < A) printf("%d %d %d", C, B, A);
	else if (B < A && A < C) printf("%d %d %d", B, C, A);
	else if (A < C && C < B) printf("%d %d %d", A, C, B);
	else if (B < A && A < C) printf("%d %d %d", B, A, C);
	else if (C < A && A < B) printf("%d %d %d", C, A, B);
}

//https://pt.stackoverflow.com/q/55978/101
