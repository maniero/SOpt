#include <stdio.h> 

enum direction { DOWN, RIGHT, UP, LEFT };

void funcaoExemplo(enum direction var) {
    if(var == DOWN) printf("%d", RIGHT); //só para testar
}
 
int main(void){
    funcaoExemplo(DOWN);
    return 0;
}

//https://pt.stackoverflow.com/q/50363/101
