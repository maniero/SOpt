#include <iostream>
#include <vector>
using namespace std;

void imprimir(vector<int> &array) {
    for (int item : array) cout << item << ' ';
}

int main() {
    vector<int> myArray = { 1, 2, 3, 4, 5 };
    imprimir(myArray);
}

//https://pt.stackoverflow.com/q/320154/101
