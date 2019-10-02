#include <iostream>
using namespace std;

int main() {
	int a = 5;
	int b = 10;
    int *r = &a;
    cout << *r << endl;
    r = &b;
    cout << *r << endl;
}

//https://pt.stackoverflow.com/q/85700/101
