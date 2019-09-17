#include <iostream>
#include <string>
using namespace std;

int main() {
	cout << "Ola, meu nome eh LOCAO, e estou aqui para te ajudar, o que voce deseja?" << endl ;
	string assunto = "conversar";
	cin >> assunto;
	if (assunto == "conversar")	cout << "Oh! Entao você quer conversar?! Sobre o que?" << endl;
	if (cin >> assunto) cout << "Ah sim, isso eh muito legal" << endl;
}

//https://pt.stackoverflow.com/q/77541/101
