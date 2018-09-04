#include <stdio.h>

int main(void) {
	int f1 = 1;
	int fn = 1;
	printf("%d ", f1 == 0 && fn == 1);
	printf("%d ", !(f1 == 0 && fn == 1));
	printf("%d\n", f1 != 0 || fn != 1);
	f1 = 0;
	printf("%d ", f1 == 0 && fn == 1);
	printf("%d ", !(f1 == 0 && fn == 1));
	printf("%d\n", f1 != 0 || fn != 1);
	while (f1 != 0 || fn != 1);
}

//https://pt.stackoverflow.com/q/327407/101
