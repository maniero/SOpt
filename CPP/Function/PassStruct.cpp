#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

struct User1 {
    string Nome;
    int NxZ;
    int hNX2;
    int kJXU;
};

int CalcJnxU(User1 x) { //x é do tipo User1 e é uma variável local desta função
    int Resultado;
    srand(time(0)) ;
    Resultado = x.hNX2 + (rand() % 4);
    return Resultado;
}

int main() {
    User1 x; //este x só existe aqui no Main, mas seu valor pode ser passado p/ outras funções
    x.Nome = "nome1";
    x.NxZ = 20;
    x.hNX2 = 2;
    x.kJXU = 2;
    cout << CalcJnxU(x);
	return 0;
}

//https://pt.stackoverflow.com/q/41864/101
