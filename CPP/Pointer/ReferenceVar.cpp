#include <iostream>
using namespace std;

int soma_b(int& a, const int& b) {
    a = 4;
    return a + b;
}

int main() {
    int x = 2;
    cout << soma_b(x, 3) << endl;
    cout << x;
}

//https://pt.stackoverflow.com/q/320739/101
