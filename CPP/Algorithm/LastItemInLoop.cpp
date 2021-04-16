#include <iostream>
#include <clocale>

using namespace std;

int main() {
    setlocale(LC_ALL, "");
    int seq[5], contS = 0;
    for (int i = 0; i < 5; i++) {
        cout << "Digite o " << i << "º número: ";
        cin >> seq[i];
        contS += seq[i];
    }
    cout << "Os números digitados foram: ";
    for (int i = 0; i < 4; i++) cout << seq[i] << " + ";
    cout << seq[4];
    cout << " = " << contS;
}

//https://pt.stackoverflow.com/q/505292/101
