#include <iostream>
using namespace std;

int main() {
    cout << "Informe o valor da aplicacao inicial: " << endl;
    float ValorInicial;
    cin >> ValorInicial;
    cout << "Informe o valor da taxa de juros inicial: " << endl;
    float JurosInicial;
    cin >> JurosInicial;
    JurosInicial /= 100;
    for (int i = 0; i < 12; i++) {
        cout << "O valor das taxas de juros em cada mes e de:  " << ValorInicial * (JurosInicial + 0.025 * i) << endl;
    }
}

//https://pt.stackoverflow.com/q/259568/101
