#include <iostream>
#include <fstream>
using namespace std;

bool ArqExiste(string Arquivo) {
    ifstream verificacao (Arquivo.c_str());
    if (verificacao.is_open()) {
        verificacao.close();
        return true;
    } else {
        verificacao.close();
        return false;
    }
}

int main() {
    string file = "C:\\Temp\\aipflib.log";
    printf("%b", ArqExiste(file));
}

//https://pt.stackoverflow.com/q/73698/101
