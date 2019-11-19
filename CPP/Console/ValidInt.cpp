#include <iostream>
#include <limits>
using namespace std;

int main() {
	float n;
	cout << "Insira um inteiro." << endl;
	while (true) {
		cin >> n;
		if (!cin.fail() && n == (int)n) break;
	    cout << n << " - Entrada nao corresponde ao tipo de variavel solicitado." << endl;
	    cin.clear();
	    cin.ignore(numeric_limits<streamsize>::max(), '\n');
	}	
    cout << endl << n << " - Entrada recebida com sucesso!!!" << endl;
}

//https://pt.stackoverflow.com/q/107543/101
