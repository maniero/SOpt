#include <iostream>
using namespace std;

class A{
public:
    int value;
};

int main(){
    A x;
    x.value = 1;
    A* ptrx = &x;
    A** pptrx = &ptrx;
    std::cout << x.value << std::endl;
    std::cout << ptrx->value << std::endl;
    std::cout << (*ptrx).value << std::endl;
    std::cout << (*pptrx)->value << std::endl;
}

//https://pt.stackoverflow.com/q/497977/101
