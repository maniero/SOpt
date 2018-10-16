#include <iostream>
#include <string>
using namespace std;

int main() {
	string a = "123456789";
	for (int c = 0; c < 10; c++) cout << a.substr(c, 1);
}

//https://pt.stackoverflow.com/q/336586/101
