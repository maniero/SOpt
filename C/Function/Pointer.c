#include <stdio.h>
 
int func( int (*x)(int,int) ) { return x(20, 5); }
int func2( int x(int,int) ) { return x(20, 5); }
int func3( int(fn)() ) { return fn(); }
int func4( int(*fn)() ) { return fn(); }
typedef int cellulae_func(int, int);
int tabula(cellulae_func *cell, int lat, int alt) { return cell(lat, alt); }
int soma(int x, int y) { return x + y; }
int sub(int x, int y) { return x - y; }
int teste() { return 42; }
int main(void) {
    printf("%d\n", tabula(soma, 20, 5));
    printf("%d\n", tabula(sub, 20, 5));
    printf("%d\n", func(soma));
    printf("%d\n", func2(soma));
    printf("%d\n", func3(teste));
    printf("%d\n", func4(teste));
    printf("%d\n", func4(soma)); //funciona, mas está errado
    int (*funcs[2])(int x, int y);
    funcs[0] = soma;
    funcs[1] = sub;
    printf("%d\n", func(funcs[0]));
}
 
//https://pt.stackoverflow.com/q/322422/101
