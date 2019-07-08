#include <iostream>
using namespace std;

bool acertou(char letra, string palavra, string &palavraAux, int &acertos) {
    bool acerto = false;
    for (int i = 0; i < palavra.length(); i++) {
        if (letra == palavra[i]) {
            acerto = true;
            acertos++;
            palavraAux[i] = letra;
        }
    }
    return acerto;
}

int main() {
	string palavra = "--------";
	int acertos = 0;
	acertou('a', "testando", palavra, acertos);
	cout << palavra;
}

//https://pt.stackoverflow.com/q/395917/101
