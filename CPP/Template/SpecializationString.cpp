#include <iostream>
#include <string>
#include <vector>
#include <string.h>
using namespace std;

template<typename T>
int len(T args) { return args.size(); }
template<>
int len(const char * args) { return strlen(args); }

int main() {
	string a = "Ola Mundo!";
	const char *b = "Ola Mundo!";
	vector<string> c = {"Ola", "Mundo", "!"};
	cout << len(a) << "\n";
	cout << len(b) << "\n";
	cout << len(c) << "\n";
}

//https://pt.stackoverflow.com/q/391548/101
