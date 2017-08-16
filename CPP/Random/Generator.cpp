#include <iostream>
#include <random>
using namespace std;

int main() {
	default_random_engine generator;
	uniform_int_distribution<int> distribution(0, 4000000);
    double populacao[10];
    double aptidao[10];
    for (int i = 0; i<10; i++) {
        populacao[i] = distribution(generator);
        cout << populacao[i] << endl;
        aptidao[i] = populacao[i];
    }
}

//https://pt.stackoverflow.com/q/229597/101
