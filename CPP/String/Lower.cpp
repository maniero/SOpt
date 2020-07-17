#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

string StrLower(string str) {
    transform(str.begin(), str.end(), str.begin(), [](char c) -> char { return tolower(c); });
    return str;
}
int main() {
    cout << StrLower("TESTE");
}

//https://pt.stackoverflow.com/q/293208/101
