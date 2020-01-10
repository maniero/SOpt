#include <iostream>
#include <random>
using namespace std;

int main() {
    random_device seed;
    mt19937 gen(seed());
    uniform_real_distribution<float> dis(-270.33, -47.5);
    cout << dis(seed);
}

//https://pt.stackoverflow.com/q/128465/101
