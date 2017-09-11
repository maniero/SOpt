#include <iostream>
using namespace std;

struct produto {
    char nome[21];
    float valorvenda;
};

int main() {
    produto prod1 = { "Caneca", 5.00 };
    cout << "Nome do Produto: \n";
    cin >> prod1.nome;
    cout << "Valor de venda: \n";
    cin >> prod1.valorvenda;
}

//https://pt.stackoverflow.com/q/236487/101
