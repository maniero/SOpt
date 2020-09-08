#include <iostream>
using namespace std;

class Equipe {
public:
    string nome;
    int numeroDeMembros = 0;
    int getMaximoDeTorcedores();
    void imprimir();
};
int Equipe::getMaximoDeTorcedores() {
    return 15 + 25 * numeroDeMembros;
}
void Equipe::imprimir() {
    cout << nome << endl;
    cout << numeroDeMembros << endl;
}
int main(){
    Equipe *e1 = new Equipe;
    Equipe *e2 = new Equipe;
    e1->nome = "Fulano";
    e2->nome = "Beltrano";
    e1->numeroDeMembros = 22;
    e2->numeroDeMembros = 12;
    cout << e1->getMaximoDeTorcedores() << endl;
    cout << e2->getMaximoDeTorcedores() << endl;
    e1->imprimir();
}

//https://pt.stackoverflow.com/q/471217/101
