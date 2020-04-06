#include <iostream>
using namespace std;

class Contador{
    unsigned int contador;
public:
    Contador(int c = 0) { contador = c; };
    int getContador() { return contador; };
    Contador& operator++() {
        ++contador;
        return *this;
    };
    Contador operator++(int) {
	    Contador temp(*this);
	    ++*this;
	    return temp;
    };
};

int main() {
    Contador c1, c2, c3;
    ++c1;
    ++c2;
    ++c2;
    ++c2;
    c3 = ++c2;
    ++(++(++c1));
    c1++;
    c2++;
    c3++;
    cout << "c1: " << c1.getContador() << endl;
    cout << "c2: " << c2.getContador() << endl; 
    cout << "c3: " << c3.getContador() << endl; 
}

//https://pt.stackoverflow.com/q/174895/101
