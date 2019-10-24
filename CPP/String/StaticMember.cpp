#include <iostream>
using namespace std;

class AlgumaClasse {

public:
	static string recebetexto;
};

string AlgumaClasse::recebetexto = "alguma frase aqui...";

int main() {
	cout << AlgumaClasse::recebetexto;
}

//https://pt.stackoverflow.com/q/94010/101
