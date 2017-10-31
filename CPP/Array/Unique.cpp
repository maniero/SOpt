#include <iostream>
using namespace std;
#define MAX_ITENS 50 //número de itens a serem lidos se quiser modificar para testes
 
int main() {
    int vet[MAX_ITENS];
    bool repetido;
    for(int i = 0; i < MAX_ITENS; i++) {
         cout << ("Numero: ");
         cin >> vet[i];
    }
    for(int i = 0; i < MAX_ITENS; i++) {
        repetido = false;
         for(int j = 0; j < i; j++) { //verifica se existem iguais apenas entre os anteriores
             if (vet[j] == vet[i]) {
                repetido = true;
                break; //tem repetido, não precisa continuar com a procura
             }
         }
         if (!repetido) {
             cout << vet[i] << endl;
         }
    }
}
 
//https://pt.stackoverflow.com/q/37002/101
