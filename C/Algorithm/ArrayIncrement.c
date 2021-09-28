#include<stdio.h>

int main(){
	float h[10];
	h[0] = 0;
	printf("h[0] = %.2f\n", h[0]);
    for (int i = 1; i < 10; i++) {
        h[i] = h[i - 1] + 0.1;
        printf("h[%d] = %.2f\n", i, h[i]);
    }
}

//https://pt.stackoverflow.com/q/529179/101
