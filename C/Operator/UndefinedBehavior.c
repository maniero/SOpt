#include <stdio.h>

int main (){
    int i = 5, j = 3, *p = &i, *q = &j, x = (*p)++;
    printf("%d %d \n", *p, x + *q);
}

//https://pt.stackoverflow.com/q/494102/101
