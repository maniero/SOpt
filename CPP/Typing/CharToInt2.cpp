#include <iostream>
#include <vector>
#include <string>
using namespace std; 

int main(){
    auto var1 = "1234";
    vector<string> empty(4, "a");
    for (auto i = 0; i < 4; i++) empty[i] = to_string(2 * (var1[i] - '0'));
    for (auto x : empty) cout << x << endl;
}

//https://pt.stackoverflow.com/q/433818/101
