#include <iostream>
#include <string>
using namespace std;

int main() {
	string &ref = *new string("teste");
	//string &ref2 = nullptr;
	string *ptr = new string("teste");
	cout << ref << endl;
	cout << ref.length() << endl;
	cout << ptr->length() << endl;
	cout << &ref << endl;
	cout << ptr;
}

//https://pt.stackoverflow.com/q/328683/101
