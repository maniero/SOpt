#include <iostream>
#include <string>
using namespace std;

int main() {
	string  resp;
	do {
		int cont = 1, tinss;
		string s, nome;
		float sal, novosala, val; 
		cout << endl << "digite o nome do funcionario: ";
		cin >> nome;
		cout << endl << "digite o salario do funcionario: ";
		cin >> sal;
		if (sal <= 500) {
			novosala = sal - ((sal / 100) * 8);
			val = (sal / 100) * 8;
			tinss = 8;				
		} else if (sal > 500 &&  sal <= 1000) {
			novosala = sal - ((sal / 100) * 10);
			val = (sal / 100) * 10;
			tinss = 10;	
		} else if(sal > 1000) {
			novosala = sal - ((sal / 100) * 12);
			val = (sal / 100) * 12;
			tinss = 12;
		}
		cout << endl << "Nome: " << nome << endl;
		cout << "Salario bruto: " << sal << endl;
		cout << "Taxa de INSS: " << tinss << endl;
		cout << "Valor de INSS " << val << endl;
		cout << "Salario liquido: " << novosala << endl;
		cout << endl << "deseja continuar ? " << endl;
		cin >> resp;
		cont++;
	}
	while (resp == "s");
}

//https://pt.stackoverflow.com/q/87784/101
