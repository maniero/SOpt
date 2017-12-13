#include <stdio.h>

int main(){
    const int length = 10;
    const int width = 5;
    const char newline = '\n';
    int area = length * width;
    printf("Value of area : %d%c", area, newline);
    printf("Value of area : %d\n", 50); //dá o mesmo resultado
}

//https://pt.stackoverflow.com/q/262455/101
