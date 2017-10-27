#include <iostream>
using namespace std;

int main(void) {
    string texto = "";
    bool palindromo = true;
    cout << "Digite a palavra : " ;
    cin >> texto;
    int tamanho = texto.length(); //retirei do loop
    //reduzi a verificação pela metade, se chegar na metade e todas comparações são iguais é palíndromo
    //o algoritmo compara a primeira metade com o inverso na segunda metade
    for (int i = tamanho / 2; i > 0; i--) {
        if (texto[i] != texto[tamanho - i - 1])  {
            palindromo = false;
            break;
        }
    }
    cout << endl << (palindromo ? "É palíndromo" : "não é palíndromo");
}

//https://pt.stackoverflow.com/q/35451/101
