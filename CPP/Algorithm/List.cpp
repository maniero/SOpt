#include <iostream>
#include <string>
#include <sstream>
using namespace std;

int main(void) {
    int dado = -1;
    string entrada = ""; //melhor ler uma string e tentar converter depois
    while (true) {
        cout << "Digite um numero inteiro: ";
        getline(cin, entrada); //pede um stream de uma linha toda
        cout << endl;
        stringstream myStream(entrada);
        if (!(myStream >> dado)) { //se não conseguir fazer a conversão
            cout << "Valor inválido, tente novamente" << endl;
            continue;
        }
        if (dado < 0) break; //se digitar o número que determina encerrar
//        inserir(fila, dado); <========== neste ponto você faz o que quiser, o valor é válido
    }
}

//https://pt.stackoverflow.com/q/41920/101
