#include <sstream>
#include <iostream>
#include <vector>

using namespace std;

int main() {
    vector<string> strings;
    istringstream texto("test;car;bar;mouse");
    string token;    
    while (getline(texto, token, ';')) {
        cout << token << endl;
        strings.push_back(token);
    }
    cout << "value by position 0 " << strings[0];
}

//https://pt.stackoverflow.com/q/446887/101
