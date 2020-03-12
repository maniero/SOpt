#include <iostream>
#include <string>
#include <map>
using namespace std;

class FichaInscricao {
public:
    string Nome;
    string Cpf;
    string Logradouro;
    string Bairro;
    string Cidade;
    string Estado;
    string Email;
    string Telefone;
    double SalarioFamiliar = 0;
    int QuantidadePessoas = 0;
    double RendaPerCapita = 0;

    void Inserir() {
        cout << "Nome: ";
        cin >> Nome;
        cout << "CPF: ";
        cin >> Cpf;
        cout << "Logradouro: ";
        cin >> Logradouro;
        cout << "Bairro: ";
        cin >> Bairro;
        cout << "Cidade: ";
        cin >> Cidade;
        cout << "Estado: ";
        cin >> Estado;
        cout << "Email: ";
        cin >> Email;
        cout << "Telefone: ";
        cin >> Telefone;
        cout << "Salario Total da Familia: ";
        cin >> SalarioFamiliar;
        cout << "Quantidade de pessoas na sua casa: ";
        cin >> QuantidadePessoas;
        RendaPerCapita = SalarioFamiliar / QuantidadePessoas;
    }
};

int main() {
    map<string, FichaInscricao> fichario;
    int op = 1;
    while (op == 1)  {
        FichaInscricao ficha;
        ficha.Inserir();
        fichario.emplace(ficha.Nome, ficha);
        cout << "\nNovo cadastro?\n"
             << "1 - SIM\n"
             << "0 - NAO\n";
        cin >> op;
    }
    for (const auto &ficha : fichario) std::cout << ficha.first << " => " << ficha.second.Cpf << '\n';
}

//https://pt.stackoverflow.com/q/157413/101
