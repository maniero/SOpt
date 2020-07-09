#include <iostream>

class Exemplo {
    public:
    void nada(int a, int b = 0);
};
void Exemplo::nada(int a, int b) { std::cout << b; }

int main() {
    Exemplo x = Exemplo();
    x.nada(1);
}

//https://pt.stackoverflow.com/q/273957/101
