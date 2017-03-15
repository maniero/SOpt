#include <stdio.h>

int main(void) {
    int x1 = 1, x2 = 2, x3 = 3, x4 = 4;
    int* p1;
    p1 = &x1;
    *p1 = 10;
    const int* p2;
    p2 = &x2;
    //*p2 = 20;
    int* const p3 = &x3;
    //p3 = &x1;
    *p3 = 30;
    const int* const p4 = &x4;
    //p4 = &x2;
    //*p4 = 40;
    printf("%d %d %d %d", *p1, *p2, *p3, *p4);
}

//http://pt.stackoverflow.com/q/190203/101
