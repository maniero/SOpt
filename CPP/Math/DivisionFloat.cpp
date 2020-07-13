#include <iostream>
using namespace std;

int main(int argc, char *argv[]) {
    auto celsius = 0.0f;
    cout << "Digite a temperatura em C°:"; cin >> celsius;
    auto fah = (9 * celsius + 160) / 5;
    cout << "Temperatura em F°:" << fah << endl;       
    cout << "Digite a temperatura em F°:"; cin >> fah;
    cout << "Temperatura em C°:" << (fah - 32) * (5.0f / 9) << endl;      
}

//https://pt.stackoverflow.com/q/278913/101
