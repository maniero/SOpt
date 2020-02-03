#include<iostream>
#include<vector>
#include<string>
using namespace std;

class Produto { //esta é uma forma bem simplificada
	public:
	    string Nome;
	    float Custo; //em código real não pode usar float para valor monetário
	    float Venda;
};
	
void novoProduto(vector<Produto> produtos) { //esta é uma forma bem ingênua de fazer isto
    produtos.push_back(Produto());
	cout << "\tNovo Produto\n";
	cout << "\nNome do Produto: ";
	cin >> produtos[produtos.size() - 1].Nome;
	cout << "\nPreco de Custo: ";
	cin >> produtos[produtos.size() - 1].Custo;
	cout << "\nPreco de Venda: ";
	cin >> produtos[produtos.size() - 1].Venda;
}

int main() {
	vector<Produto> produtos;
	int op;
	do {
		cout << "\n\tCadastro de Produto\n";
		cout << "\n<1> Novo Produto";
		cout << "\n<2> Listar Produtos";
		cout << "\n\tOpcao: ";
		cin >> op;
		system("cls");
		switch (op) {
			case 1:
				novoProduto(produtos);
				break;
		}
	} while (op != 0);
}

//https://pt.stackoverflow.com/q/137471/101
