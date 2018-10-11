#include <iostream>
using namespace std;

int ActionGenerator() {
    int Action;
    while(true) {
        cout << endl << "SELECIONE UMA ACTION: " << endl;
        cout << "[1 = ActionX]" << endl << "[2 = ActionZ]" << endl;
        cin >> Action;
        if (Action == 1 || Action == 2) return Action;
        else {
            cout << endl << "ACTION INVALIDA !" << endl;
            cin.clear(); //Limpa a flag de erro quando há falha no parse do valor entrado
            cin.ignore(); //Limpa o buffer
        }
    }
}

int main() {
    cout << ActionGenerator() << endl << "ok" <<endl;
}

//https://pt.stackoverflow.com/q/41855/101
