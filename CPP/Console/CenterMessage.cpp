#include <iostream>
#include <string>
//#include <windows.h>
using namespace std;

string Center(string str) {
   int espacos = (int)((21 - str.length())/2);
   return string(espacos, ' ') + str + string(espacos + (str.length() > espacos * 2 ? 1 : 0), ' ');
}

int main() {
	string mensagem;
//	HANDLE handle = GetStdHandle(STD_OUTPUT_HANDLE);
    cout << "Digite um palavara: ";
    cin >> mensagem;
//    SetConsoleTextAttribute( handle, 12 );
    cout << "***************************" "\n";
    cout << "***************************" "\n";
    cout << "***                     ***" "\n";
    cout << "***                     ***" "\n";
    cout<< "***" << Center(mensagem) << "***""\n";
    cout << "***                     ***" "\n";
    cout << "***                     ***" "\n";
    cout << "***************************" "\n";
    cout << "***************************" "\n";
//    SetConsoleTextAttribute( handle, 0 );
	return 0;
}

//https://pt.stackoverflow.com/q/50496/101
