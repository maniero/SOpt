#include <string>
using namespace std;

class Teste2 {
	int x;
	int y;
	public:
	    Teste2(int x, int y) {}
};
class Testando {
    Teste2 *teste2;
	public:
	    Testando(Teste2 *teste2) {}
};
class Teste : public Testando {
    string nome;
    int numero;
    public:
         //Supondo que Teste2 teste2 foi instanciado na Classe Testando
        Teste(Teste2 *teste2, string nome, int numero) : Testando(teste2) {      
            this->nome = nome;
            this->numero = numero;
        }
};
int main() {
	auto teste = Teste(new Teste2(1, 2), "joão", 1);
}

//https://pt.stackoverflow.com/q/120253/101
