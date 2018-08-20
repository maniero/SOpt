#include <iostream>
#include <array>
using namespace std;

int main() {
    int item, qtde;
    cin >> item >> qtde;
    array<float, 5> valores = { 4.00, 4.50, 5.00, 2.00, 1.50 };
    cout << "Total: R$" << valores[item - 1] * qtde;
}

//https://pt.stackoverflow.com/q/322871/101
