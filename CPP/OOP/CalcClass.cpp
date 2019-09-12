#include <iostream>
using namespace std;

class Efetua_calculo {
private:
    double total;
public:
    void mostra_calculo(); //aqui só cabe a declaração e não a definição
    double soma(); //declarei essa função que não estava declarada
    double divide(); //idem, estava declarada como variável
};
double Efetua_calculo::soma(){
    int valor1 = 2;
    int valor2 = 3;
    total = valor1 + valor2;
    return (total);
}
double Efetua_calculo::divide(){
    int valor1 = 2;
    int valor2 = 3;
    total = (double) valor1/valor2;
    return(total);
}
void Efetua_calculo::mostra_calculo(){ //trouxe a implementação p/ cá
    cout << "Resultado das funcoes soma() e divide() e :" << endl;
    cout << soma() << endl;
    cout << divide() << endl;
    return;
}
int main() {
    Efetua_calculo calculo;
    calculo.mostra_calculo(); //tinha erro de digitação aqui
    return 0;
}

//https://pt.stackoverflow.com/q/75952/101
