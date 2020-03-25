#include <iostream>
using namespace std;

class Tipo {
    int x;
public:
    Tipo() {
        x = 0;
        cout << "construtor padrão\n";
    }
    Tipo(int p) {
        x = p;
        cout << "construtor com parâmetro\n";
    }
};

class sof {
    Tipo teste; //chama o construtor padrão
public: 
    sof(int t) {
        teste = Tipo(t); //chama o outro construtor
    }
};

class sof2 {
    Tipo teste; //não chama nada
public: 
    sof2(int t) : teste(t) {} //chama o construtor com parâmetro
};
    
int main() {
	sof exemplo(10);
	cout << endl;
	sof2 exemplo2(10);
}

//https://pt.stackoverflow.com/q/169175/101
