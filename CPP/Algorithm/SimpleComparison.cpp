#include <iostream>
using namespace std;

int main() {
	int a, b;
	cout << "Digite quantos Gol(s) o Brasil fez: ";
	cin >> b;
	cout << "Digite quantos Gol(s) a Argentina fez: ";
	cin >> a;
	if (b > a) cout << "\nBrasil ganhou com "<< b << " Gol(s)\n";
	else if (a == b) cout << "Houve empate. " << a << "Gol(s)";
	else cout << "\nArgetina ganhou com " << a << " Gol(s)\n";
}

//https://pt.stackoverflow.com/q/137365/101
