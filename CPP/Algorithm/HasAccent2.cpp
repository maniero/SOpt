#include <iostream>
#include <string>
using namespace std;

bool temAcento(string palavra) {
    for (int a = 0; a < palavra.size(); a++) {
        string comAcento = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûù";
        for (int b = 0; b < comAcento.size(); b++) {
            if (palavra[a] == comAcento[b]) {
                cout << "Não digite letras com acento";
                return true;
            }
        }
    }
    return false;
}

int main() {
    setlocale(LC_ALL, "ptb");
    while (true) {
    	string palavra;
        cout << "Informe uma palavra: ";
        cin >> palavra;
        if (!temAcento(palavra)) break;
    }
}

//https://pt.stackoverflow.com/q/447739/101
