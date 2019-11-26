#include <iostream>
#include <iomanip>
#include <cmath>
using std::cout;
using std::cin;
using std::endl;
using std::fixed;
using std::setw;
using std::setprecision;
using std::pow;

bool isEqual(double x, double y) {
    return std::abs(x - y) <= 1e-5 * std::abs(x);
}

int main() {
    //quantia em depósito no fim de cada ano.
    double deposito;
    //quantia inicial antes dos juros.
    double principal = 1000.0;
    //taxa de juros.
    double taxa;
    cout<<"Insira a taxa de juros entre 0.05 á 0.10: ";
    cin>>taxa;
    //exibe cabeçalhos.
    cout << " Ano(s) " << setw(21)<<"Quantidade depositada"<<endl;
    //configura o formato de saída do valo de ponto flutuante.
    cout << fixed << setprecision(2);
    //calcula a quantia de depósito para cada um dos dez anos.
    for (int ano = 1; ano <= 10; ano++) {
        if (isEqual(taxa, .05)) {
            //calcula a nova quantia durante o ano especificado
            deposito = principal * pow(1.0 + taxa, ano);
            //exibe o ano e a quantia
            cout << setw(4) << ano << setw(21) << deposito << endl;
        } else if (isEqual(taxa, .06)) {
            deposito = principal * pow(1.0 + taxa, ano);
            cout << setw(4) << ano << setw(21) << deposito << endl;
        } else if (isEqual(taxa, .07)) {
            deposito = principal * pow(1.0 + taxa, ano);
            cout << setw(4) << ano << setw(21) << deposito << endl;
        } else if (isEqual(taxa, .08)) {
            deposito = principal * pow(1.0 + taxa, ano);
            cout << setw(4) << ano << setw(21) << deposito << endl;
        } else if (isEqual(taxa, .09)) {
            deposito = principal * pow(1.0 + deposito, ano);
            cout << setw(4) << ano << setw(21) << deposito << endl;
        } else if (isEqual(taxa, .10)) {
            deposito = principal * pow(1.0 + taxa, ano);
            cout << setw(4) << ano << setw(21) << deposito << endl;
        } else {
            //para que não seja recebido um valor além do especificado.
            cout<<"O valor de taxa inserido é inválido. ";
            return 0;
        }
    }
}

//https://pt.stackoverflow.com/q/108998/101
