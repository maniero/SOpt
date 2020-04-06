#include <iostream>
using namespace std;

class Contador {
    public:
        Contador(int c = 0) { contador = c; };
        int getContador() { return contador; };
        Contador& operator++() {
            ++contador;
            return *this;
        };
    private:
        unsigned int contador;
};

int main() {
    Contador c1, c2, c3;
    ++c1;
    ++c2;
    ++c2;
    ++c2;
    c3 = ++c2;
    ++(++(++c1));
    cout << "c1: " << c1.getContador() << endl;
    cout << "c2: " << c2.getContador() << endl; 
    cout << "c3: " << c3.getContador() << endl; 
}

//https://pt.stackoverflow.com/q/174895/101
