#include <iostream>
#include <vector>
using namespace std;

int main () {
    vector<int> vetor;
    for (int i = 0; i < 10; i++) vetor.push_back(i);
    for (auto it = vetor.begin(); it != vetor.end(); it++) cout << ' ' << *it;
}

//https://pt.stackoverflow.com/q/164232/101
