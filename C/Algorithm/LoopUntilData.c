#include <stdio.h>

int main(void) {
	int sum = 0;
	while (1) {
		int num = -1;
	    scanf("%d", &num);
	    if (num >= 0) sum += num;
	    else break;
    }
}

//https://pt.stackoverflow.com/q/167698/101
