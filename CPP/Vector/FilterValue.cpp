#include <iostream>
#include <vector>
using namespace std;

template<typename T> 
vector<T> filter(vector<T> base, T val) {
    vector<T> temp;
    temp.resize(0);
    for (auto it : base) if (it == val) temp.push_back(it);
    return temp;
}

int main() {
	vector<int> v = {7, 5, 16, 8, 5, 12, 1};
	for (auto it : filter(v, 5)) cout << it << endl;
}

//https://pt.stackoverflow.com/q/215352/101
