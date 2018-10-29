#include <stdio.h>
int main() {
	int a, b, c;
	scanf("%d", &a);
	scanf("%d", &b);
	scanf("%d", &c);
	if (a > 0 && b > 0 && c > 0 && a < b + c && b < a + c && c < a + b) {
	    if (a == b && b == c) printf("%s", "Triangulo equilatero.");
	    else printf("%s", (a == b || b == c || c == a) ? "Triangulo isosceles." : "Triangulo escaleno.");
	} else printf("Nao e possivel formar um triangulo."); 
}

//https://pt.stackoverflow.com/q/339064/101
