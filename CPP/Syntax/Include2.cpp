#ifndef PROJETO_H
#define PROJETO_H

#include <string>
using namespace std;

class projeto {
private:
    string codprojeto;
    int estprojeto;
    int faseprojeto;
    int funcao;
public:
    projeto();
    bool regcod(string cod);
    string consultarcod();
};

#endif // PROJETO_H

int main() {}

//https://pt.stackoverflow.com/q/148635/101
