#include <iostream>
#include <string>
#include <vector>
#include <string.h>
#include <type_traits>

using namespace std;

template<typename T>
int len(T args) {
    if constexpr (is_same_v<T, const char*>) return strlen(args);
    else return args.size(); 
}

int main() {
    string a = "Ola Mundo!";
    const char *b = "Ola Mundo!";
    vector<string> c = {"Ola", "Mundo", "!"};
    cout << len(a) << "\n";
    cout << len(b) << "\n";
    cout << len(c) << "\n";
}

//https://pt.stackoverflow.com/q/391548/101
