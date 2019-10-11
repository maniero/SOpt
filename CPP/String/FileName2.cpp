#include <iostream>
#include <cstdlib>
#include <fstream>
#include <string>
#include <ctime>
#include <vector>
#include <memory>
using namespace std;


void apaga_espaco(ifstream& tab, vector<time_t> t) {
    string nome = "gremio";
    int saldo = 0;
    int vit = 1, i = 0;
    string s;
    char N;
    while (tab.good()) {
        i++;
        getline(tab, s);
        s.erase(0, 29);
        N = s.find(':');
        s.erase(0, N + 6);
    }
}

int main() {
    vector<time_t> t(20); 
    ifstream tabe;
    char N;
    string s;
    tabe.open("Tabela.txt", ios::in);
    if (!tabe.is_open()) {
        cout << "Arquivo nao encontrado, erro fatal!";
        exit(1);
    }
    apaga_espaco(tabe, t);
}

//https://pt.stackoverflow.com/q/89562/101
