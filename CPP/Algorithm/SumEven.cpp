#include <iostream>
using namespace std;

int main() {
    int x, y, r = 0;
    cin >> x >> y;
    if (x < y) {
    	for (; x < y; x++) if (x % 2 != 0) r += x;
    } else {
    	for (; y < x; y++) if (y % 2 != 0) r += y;
    }
    cout << r << endl;
}

//https://pt.stackoverflow.com/q/334198/101
