#include <iostream>
#include <math.h>
using namespace std;

 struct Ponto{
    float x;
    float y;
 }; 
void LerRetangulo(Ponto ret[], int tam) {
    for(int i = 0; i < tam; i++) {
        cout << "digite coordenadas x e y  do ponto " << i + 1 << endl;
        cin >> ret[i].x >> ret[i].y;
    }
}

double CalcDistancia(Ponto ret[], int tam) {
    double distancia = 0;
    for(int i = 0; i < tam; i++) {
        distancia += sqrt(pow(ret[i].x, 2) + pow(ret[i].y, 2));
    }
    return distancia;
}

void imprimir(double distancia, Ponto ret[], int tam) {
    for (int i = 0; i < tam; i++) {
        cout << "Ponto " << i << " = " << ret[i].x << ", " << ret[i].y <<endl;
    }
    cout << "Distância = " << distancia << endl;
}

int main(int argc, char *argv[]) {
    Ponto retangulo[4];
    LerRetangulo(retangulo, 4);
    imprimir(CalcDistancia(retangulo, 4), retangulo, 4);
}

//https://pt.stackoverflow.com/q/54826/101
