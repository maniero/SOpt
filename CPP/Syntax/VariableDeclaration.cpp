#include <iostream>
using namespace std;

int main() {
	cout << "Quantidade de notas: ";
	int qt;
	cin >> qt;
	int nt[qt] = {}; //isto é mais C que C++
	int tot = 0;
	for (int i = 0; i < qt; i++) {
	    cout << "Digite a nota " << i + 1 << " : " << endl;
	    cin >> nt[i];
	    tot += nt[i];
	}
	cout << "Media = " << tot / qt << endl;
}

//https://pt.stackoverflow.com/q/262773/101
