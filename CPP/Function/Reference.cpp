#include <iostream>
using namespace std;
int getNumber(bool &check) {
    check = !check;
    return check ? 10 : 20;
}

int main() {
    bool numero = false;
    cout << getNumber(numero) << endl;
    cout << getNumber(numero) << endl;
    cout << getNumber(numero) << endl;
}

//https://pt.stackoverflow.com/q/45723/101
