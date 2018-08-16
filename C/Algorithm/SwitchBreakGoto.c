#include<iostream>
using namespace std;

int main() {
    while (true) {
        int consumo;
        cout << "Digite 1 -> até 100kw" << endl;
        cout << "Digite 2 -> de 101kw até 200kw" << endl;
        cout << "Digite 3 -> maior que 200kw" << endl;
        cin >> consumo;
        switch (consumo) {
        case 1:
            cout << "Parabéns, você é econômico." << endl;
            goto fim;
        case 2:
            cout << "Cuidado, você está gastando muito." << endl;
            goto fim;
        case 3:
            cout << "Que isso vei?" << endl;
            goto fim;
        }
    }
fim:
    return 0;
}

//https://pt.stackoverflow.com/q/322634/101
