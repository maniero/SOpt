#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;

int main() {
    srand(time(NULL));
    cout << "Dado_1: " << rand() % 6 + 1 << "\n";
    cout << "Dado_2: " << rand() % 6 + 1 << "\n";
}

//http://pt.stackoverflow.com/q/189434/101
