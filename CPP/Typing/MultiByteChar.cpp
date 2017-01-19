#include <iostream>
using namespace std;
 
int main() {
    char a = 'a';
    char b = 'ã';
    wchar_t c = 'a';
    wchar_t d = 'ã';
    cout << sizeof(char) << "\n";
    cout << sizeof(a) << "\n";
    cout << sizeof('a') << "\n";
    cout << sizeof(b)  << "\n";
    cout << sizeof(c)  << "\n";
    cout << sizeof(d)  << "\n";
    cout << sizeof('ã')  << "\n";
}

//http://pt.stackoverflow.com/q/178456/101
