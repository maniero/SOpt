#include <stdio.h>
 
int main () {
    int x = 0;
    while (x < 10) {
    	printf("%d\n", x);
    	if (x % 2 == 0) {
    		x++;
    		continue;
    	}
    	x++;
    }
}

//https://pt.stackoverflow.com/q/80589/101
