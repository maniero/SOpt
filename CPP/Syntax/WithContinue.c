#include <stdio.h>
 
int main () {
    int a = 10;
    do {
        if ( a < 15) {
            a++;
            continue;
        }
        printf("value of a: %d\n", a);
        a++;
    } while( a < 20 );
}

//https://pt.stackoverflow.com/q/80589/101
