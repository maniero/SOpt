#include <iostream>
#include <cstdio>
using namespace std;

long long int factorial(long long int num) {
    if(num == 1 || num == 0) return 1;
    return num * factorial(num - 1);
}

int main() {
    long long int M, N;
    while (scanf("%lli %lli", &M, &N) != EOF) cout << factorial(M) + factorial(N) << endl;
}

//https://pt.stackoverflow.com/q/396814/101
