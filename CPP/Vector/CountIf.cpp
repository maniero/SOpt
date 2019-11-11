#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main() {
    vector<int> v = { 1, 2, 3, 45, 24, 10, 20, -90, 100, 18, 17, 15, 87 };
    cout << count_if(v.cbegin(), v.cend(), [](int i) { return i >= 10 && i <= 20;});
}

//https://pt.stackoverflow.com/q/104151/101
