#include <iostream>
#include <string>

using namespace std;

int main() {
    string nome;
    cin >> nome;
    for (int i = nome.length() - 1; i >= 0; i--) {
        cout << nome[i];
    }
}

//http://pt.stackoverflow.com/q/190443/101
