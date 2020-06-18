#include <iostream>
using namespace std;

int main() {
	int i;
    cin >> i;
    int vet[i];
    for (int t = 0; t < i; t++) cin >> vet[t];
    for (int f = i - 1; f >= 0; f--) cout << vet[f] << " ";
}

//https://pt.stackoverflow.com/q/241794/101
