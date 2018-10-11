#include <iostream>
#include <string>
#include <sstream>

using namespace std;

int ActionGenerator() {
    int Action;
    string Input = "";
    while(true) {
        cout << endl << "SELECIONE UMA ACTION: " << endl;
        cout << "[1 = ActionX]" << endl << "[2 = ActionZ]" << endl;
        getline(cin, Input);
        stringstream myStream(Input);
         if ((myStream >> Action) && (Action == 1 || Action == 2)) return Action;
        else cout << endl << "ACTION INVALIDA !" << endl;
    }
}

int main() {
    cout << ActionGenerator() << endl << "ok" <<endl;
}
    
//https://pt.stackoverflow.com/q/41855/101
