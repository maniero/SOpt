#include <iostream>
#include <vector>
using namespace std;

struct Atom {
    int multiplier;
    string part;
};

vector<Atom> cracking(string chemform) {
    return { { 10, chemform }, { 20, "teste" } };
}
int main() {
    vector<Atom> atoms =cracking("item");
    cout << atoms[0].multiplier << " " << atoms[0].part << endl;
    cout << atoms[1].multiplier << " " << atoms[1].part << endl;
}

//https://pt.stackoverflow.com/q/262791/101
