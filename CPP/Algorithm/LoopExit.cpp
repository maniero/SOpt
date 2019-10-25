
#include <iostream>
using namespace std;

int main() {
	int maior = 0, numero = 0;
	while (numero >= 0) {
	    cin >> numero;
	    if (numero > maior) {
	    	maior = numero;
	        cout << "maior ate agora " << maior << endl;
	    }
	}
}

//https://pt.stackoverflow.com/q/96865/101
