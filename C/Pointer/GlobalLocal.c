#include <stdio.h>
int *pnum;
void teste() {
	printf("%d\n", *pnum);
}
void teste2() {
	int num = 20;
	pnum = &num;
}
void teste3() {
	int num = 30;
	num++;
}
int main() {
    int num = 10;
    pnum = &num;
    teste();
    teste2();
    teste3();
    teste();
}

//https://pt.stackoverflow.com/q/99551/101
