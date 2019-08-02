#include <iostream>
#define tamanho 10
const int elementos = 10;
using namespace std;

int main() {
	int a = 1;
	char b = 'a';
	float c = 1.0f;
	double d = 2.0d;
	short e = 1000;
	long f = 100000;
	int *g = new int[tamanho];
	int h[elementos];
	cout << "a tem " << sizeof(a) << " bytes\n";
	cout << "b tem " << sizeof(b) << " bytes\n";
	cout << "c tem " << sizeof(c) << " bytes\n";
	cout << "d tem " << sizeof(d) << " bytes\n";
	cout << "e tem " << sizeof(e) << " bytes\n";
	cout << "f tem " << sizeof(f) << " bytes\n";
	cout << "g tem " << sizeof(g) << " bytes\n";
	cout << "h tem " << sizeof(h) << " bytes\n";
}

//https://pt.stackoverflow.com/q/52142/101
