#include <iostream>
#include <cstdio>
#include <string>
using namespace std;

typedef struct {
    int ID;
    string nome;
    string tel;
} Pessoa;

int main() {
    int vet[10] = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    char opc = 'z';    
    do {
	    cout << "[1] incluir pessoa" << endl;
	    cout << "[2] Alterar pessoa" << endl;
	    cout << "[3] Excluir pessoa" << endl;
	    cout << "[4] Recuperar pessoa" << endl;
	    cout << "[0] Sair" << endl;
	    opc = cin.get();
	    switch (opc) {
	        case '0':
		        break;
	        case '1':
	            cout << "1" << endl;
		        break;  
	        case '2':
		        cout << "2" << endl;
	        break;
	        case '3':
	            cout << "3" << endl;
		        break;
	        case '4':
	            cout << "4" << endl;
		        break;
	        default:
	            cout << "Opção Invalida" << endl;
	    }
    } while (opc != '0');
}

//https://pt.stackoverflow.com/q/254999/101
