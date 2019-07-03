#include <iostream>
using namespace std;

struct Funcionario {
	string nome;
	string setor;
	int cartao;
};

void inserir(Funcionario& func) {
	cin >> func.nome;
	cin >> func.setor;
	cin >> func.cartao; 
}

int main() {
	setlocale(LC_ALL,"Portuguese");
	Funcionario funcionarios[10];
	int p = 0;
	do {
	    cout << "O que você deseja fazer?\nDigite \"1\" para inserir.\nDigite\"2\" para buscar.\n";
	    int opcao = 0;
	    cin >> opcao;
	    if (opcao != 1 && opcao != 2) cout << "Valor digitado inválido, digite novamente.\n";
	    else if (opcao == 1) {
	        inserir(funcionarios[p]);
	        p++;
	    }
	} while (p < 10);
}

//https://pt.stackoverflow.com/q/394980/101
