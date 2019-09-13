void teste();

void main() {
    teste();
}

void teste() {
    printf("teste");

#include "teste.hpp"
void funcao() {
    teste();
}

void teste();
void funcao() {
    teste();
}

//https://pt.stackoverflow.com/q/76782/101
