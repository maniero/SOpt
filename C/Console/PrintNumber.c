#include <stdio.h>

void triangulo(int n) {
	for (int i = 1; i <= n; i++) {
		for (int j = 1; j <= i; j++) printf("%d ", j);
		printf("\n");
	}
}

int main() {
     int n;
     scanf("%d", &n);
	 triangulo(n); 	 
}

//https://pt.stackoverflow.com/q/339810/101
