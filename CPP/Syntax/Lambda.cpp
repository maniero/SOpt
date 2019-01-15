#include <iostream>
using namespace std;

int main() {
    auto gerador = []() { return 5 + rand() % 5 + 1; };
    int number = gerador();
    cout << number << endl;
    number = gerador();
    cout << number << endl;
}

//https://pt.stackoverflow.com/q/44727/101
