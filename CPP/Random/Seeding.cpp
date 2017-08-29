#include <iostream>
#include <iomanip>
#include <ctime>
#include <cstdlib> // contém o protótipo de função para rand
using namespace std;

int main() {
    srand(time(NULL));
    int frequency1 = 0; // contagem de 1s lançado
    int frequency2 = 0; // contagem de 2s lançado
    int frequency3 = 0; // contagem de 3s lançado
    int frequency4 = 0; // contagem de 4s lançado
    int frequency5 = 0; // contagem de 5s lançado
    int frequency6 = 0; // contagem de 6s lançado
    int face; // armazena o valor lançado mais recente
    for (int roll = 1; roll <= 6000000; roll++) {
        face = 1 + rand() % 6;
        switch (face) {
            case 1:
                ++frequency1;
                break;
            case 2:
                ++frequency2;
                break;
            case 3:
                ++frequency3;
                break;
            case 4:
                ++frequency4;
                break;
            case 5:
                ++frequency5;
                break;
            case 6:
                ++frequency6;
                break;
            default:
                cout << "Program should never get here!";
        } // fim do switch
    } // fim do for
    cout << "Face" << setw(13) << "Frequency" << endl;
    cout << "  1" << setw(13) << frequency1
        << "\n  2" << setw(13) << frequency2
        << "\n  3" << setw(13) << frequency3
        << "\n  4" << setw(13) << frequency4
        << "\n  5" << setw(13) << frequency5
        << "\n  6" << setw(13) << frequency6 << endl;
}  // fim de main

//https://pt.stackoverflow.com/q/233163/101
