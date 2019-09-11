#include <iostream>
using namespace std;

void Test2(int *i) {
	int p = 147;
    i = &p;
}

int main() {
	int *p[10];
	int num = 10;
	p[0] = &num;
	cout << *p[0] << endl;
	Test2(p[0]);
	cout << *p[0] << endl;
}

//https://pt.stackoverflow.com/q/408757/101
