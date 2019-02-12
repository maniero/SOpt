#include <iostream>
using namespace std;

int main() {
    int i = 1;
    auto loop = [=]() { cout << i; };
    loop();
}

//https://pt.stackoverflow.com/q/361612/101
