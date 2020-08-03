#include <iostream>
using namespace std;

struct Pai {
	virtual void imprimir() {
		cout << "Classe pai\n";
	}
};

struct Filha : Pai {
	void imprimir() override {
		cout << "Classe filha\n";
	}
};

int main() {
	Pai *obj = new Filha{};
	obj->imprimir();
	delete obj;
}

//https://pt.stackoverflow.com/q/466171/101
