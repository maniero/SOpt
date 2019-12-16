#include <iostream>
#include <string>
#include <vector>
using namespace std;

class Nome {
	protected:
    	string nome;
    public:
        Nome(string _nome) {
			nome = _nome;
		}
        virtual void exibirNome() = 0;
};
class SobreNome : public Nome {
    string sobre_nome;
	public:
	    SobreNome(string nome, string _sobre_nome) : Nome(nome) {
		    sobre_nome = _sobre_nome;
		}
	    void exibirNome() {
			cout << nome << " " << sobre_nome;
		}
};

int main() {
    vector<Nome*> nome;
    Nome *n = new SobreNome("João", "Alves");
    nome.push_back(n);
    nome[0]->exibirNome();
}

//https://pt.stackoverflow.com/q/120231/101
