#include <iostream>
using namespace std;

int main() {
	int totalempresa = 0;
    while (1) {
    	int valordomes1, valordomes2, valordomes3;
        cout << "valor do mes 1:";
        cin >> valordomes1;
        if (valordomes1 == 0) break;
        cout << endl << "valor do mes 2:";
        cin >> valordomes2;
        cout << endl << "valor do mes 3:";
        cin >> valordomes3;
        int totalfilia = valordomes1 + valordomes2 + valordomes3;
        cout << endl << "Valor total da filial: " << totalfilia << endl;
        cout << "------------------------------------" << endl;
        totalempresa += totalfilia;
        cout << "Total do restaurante: " << totalempresa << endl;
        cout << "se nao deseja calcular o proximo valor de vendas de outra filial digite o numero zero" << endl;
    }
}

//https://pt.stackoverflow.com/q/387057/101
