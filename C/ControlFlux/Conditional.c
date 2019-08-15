#include <iostream>
using namespace std;

int main() {
    int x, y, z, ft, sd, th;
    while(true) {
	    cout << "Digite 3 valores reais e diferentes: \n";
	    cin >> x;
	    cin >> y;
	    cin >> z;

	    if (z == y || x == z || x == y) {
	        cout << "\nErro. Os valores devem ser diferentes de 0 e nao repetidos. Tente novamente: \n" << endl;
	        continue;
	    }
	    break;
    }
    if (x > y && x > z) {
        ft = x;
    } else if (x > y && x < z) {
        sd = x;
    } else if (x > z && x < y) {
        sd = x;
    } else if (x < y && x < z) {
        th = x;
    }
    if (y > x && y > z) {
        ft = y;
    } else if (y < x && y > z) {
        sd = y;
    } else if (y < z && y > x) {
        sd = y;
    } else if (y < x && y < z) {
        th = y;
    }
    if (z > x && z > y) {
        ft = z;
    } else if (z < x && z > y) {
        sd = z;
    } else if (z < y && z > x) {
        sd = z;
    } else if (z < x && z < y) {
        th = z;
    }
    cout << "\nOs valores ordenados sao: \n" << endl;
    cout << "Valor mais alto: " << ft<< endl;
    cout << "Valor intermediario: " << sd<< endl;
    cout << "Valor mais baixo: " << th<< endl;
}

//https://pt.stackoverflow.com/q/53572/101
