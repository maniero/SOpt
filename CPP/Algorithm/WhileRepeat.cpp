#include <iostream>
#include <vector>
using namespace std;

struct Carros {
    string nome;
    int coresDisp, motores, modelos, ano;
};

int main(){
    vector<string> cores = { "Vermelho", "Azul", "Verde", "Amarelo", "Preto", "Branco", "Cinza" };
    vector<string> motores = { "2.0", "1.5", "1.0" };
    vector<string> modelos = { "Completo", "Medio", "Basico" };
    vector<int> ano;
    for (int i = 2005; i <= 2020; i++) ano.push_back(i);
    Carros car1 = { "Vulcano" };
    Carros car2 = { "Tornado" };
    Carros car3 = { "Furia" };
    Carros car4 = { "Ninjasso" };
    cout << "Carros disponiveis: \n\n\n";
    cout << car1.nome << "[1]     " << car2.nome << "[2]     " << car3.nome << "[3]     " << car4.nome << "[4]     ";
    cout << "\n\n     :               ";
    while (true) {
	    int escolha = 0;
        cin >> escolha;
        if (escolha > 0 && escolha < 5) break;
        cout << "Essa escolha naum eh valida, tente novamente: ";
    }
}

//https://pt.stackoverflow.com/q/395768/101
