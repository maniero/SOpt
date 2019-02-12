#include <iostream>
using namespace std;

int main() {
    int i = 1;
    auto loop = [=]() { cout << i; }; //não pode fazer o incremento aqui
    loop();
    auto loop2 = [&]() { cout << i++; };
    loop2();
    cout << i;
}

//https://pt.stackoverflow.com/q/361612/101
