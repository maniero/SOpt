#include <iostream>
#include <string>
using namespace std;
 
int main() {
	string a = "123456789";
	for (char& c : a) cout << c;
}

//https://pt.stackoverflow.com/q/336586/101
