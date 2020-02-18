#include <iostream>
#include <string>
using namespace std;

int main() {
	string texto = "";
	while (true) {
	    int num;
	    cout << "Digite o numero binario de 8 dígitos (dígite 0 para parar): ";
	    cin >> num;
	    cout << endl;
	    if (num == 0) break;
	    int dec = 0, d = 1;
	    do {
		    dec += num % 10 * d;
		    d *= 2;
		    num /= 10;
	    } while (num != 0);
	    if (!((dec >= 65 && dec <= 90) || (dec >= 97 && dec <= 122))) {
   		    cout << "Valor digitado está fora da faixa permitida" << endl;
            continue; 
	    }
	    texto += "ABCDEFGHIJKLMNOPQRSTUVXYZ"[(dec &  ~32) - 65];
	}
    cout << texto;
}

//https://pt.stackoverflow.com/q/148933/101
