#include <iostream>
#include <algorithm>
#include <cstring>
using namespace std;

int main() {
    int numero[3], ent[3];
    cin >> ent[0];
    cin >> ent[1];
    cin >> ent[2];
    sort(numero, numero + 3);
    cout << numero[0] << ", " << numero[1] << ", " << numero[2] << endl ;
    cout << ent[0] << ", " << ent[1] << ", " << ent[2];
}

//https://pt.stackoverflow.com/q/323411/101
