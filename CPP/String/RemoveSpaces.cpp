#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int main() {
	string str = " texto com espaços em branco ";
	str.erase(remove(str.begin(), str.end(), ' '), str.end());
	cout << str;
}

//https://pt.stackoverflow.com/q/90623/101
