#include <regex>
#include <string>
#include <iostream>
using namespace std;

int main() {
	string texto = "gabriel = 1.73,derp = 1.80,";
	regex padrao("gabriel = (.*?),");
	cout << regex_replace(texto, padrao, "gabriel = 1.75,");
	return 0;
}

//https://pt.stackoverflow.com/q/50418/101
