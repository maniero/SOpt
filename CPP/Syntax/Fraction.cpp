#include <iostream>
#include <exception>
#include <string>
using namespace std;

class Fracao {
private:
    int numerador;
    int denominador;
public:
    Fracao(int numerador, int denominador);
};

Fracao::Fracao(int numerador, int denominador) {
    this->numerador = numerador;
    if (denominador != 0) this->denominador = denominador;
    else throw "Impossivel dividir por zero";
}

Fracao HandleExceptionFracao(int numerador, int denominador) {
    try {
        Fracao f(numerador, denominador);
        return f;
    } catch (const char* msg) {
        cerr << "Erro: " << msg << endl;
    } catch(...) {
        cerr << "Erro desconhecido\n";
    }
}

int main() {
	Fracao f1 = HandleExceptionFracao(1, 0);
}

//https://pt.stackoverflow.com/q/155360/101
