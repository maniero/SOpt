#include <iostream>
#include <string>
using namespace std;

int main() {
    setlocale(LC_ALL, "ptb");
inicio:
    string palavra;
    cout << "Informe uma palavra: ";
    cin >> palavra;
    for (int a = 0; a < palavra.size(); a++) {
        string comAcento = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûù";
        for (int b = 0; b < comAcento.size(); b++) {
            if (palavra[a] == comAcento[b]) {
                cout << "Não digite letras com acento";
                goto inicio;
            }
        }
    }
}

//https://pt.stackoverflow.com/q/447739/101
