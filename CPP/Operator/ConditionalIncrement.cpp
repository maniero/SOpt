#include <iostream>
using namespace std;

int main() {
	int k = 0;
    for (int i = 0; i < 10; i++) {
        k += !((4 + (~i + 1)) & 0x80000000);
    }
    cout << k << endl;
}

//https://pt.stackoverflow.com/q/268749/101
