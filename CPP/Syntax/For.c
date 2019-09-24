#include <stdio.h>
 
int main () {
    for (int x = 0; x < 10; x++) {
    	printf("%d\n", x);
    	if (x % 2 == 0) {
    		x++;
    		continue;
    	}
    }
}

//https://pt.stackoverflow.com/q/80589/101
