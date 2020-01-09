#include <iostream>
using namespace std;

class Interfaceable {
public:
    virtual void Interface() = 0; // isto é um método puramente virtual
};

class Classe: public Interfaceable {
public:
    void Interface();
};

void Classe::Interface() {
    cout << "interface\n";
}

void Teste(Interfaceable& p) {
	p.Interface();
}

int main() {
	auto x = Classe();
	x.Interface();
	Teste(x);
}

//https://pt.stackoverflow.com/q/127279/101
