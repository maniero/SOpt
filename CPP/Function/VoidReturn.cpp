#include<iostream>
#include<vector>
using namespace std;

void imprime(vector<vector<double>> X) {
    int linhas  = X.size();
    for (int i = 0; i < linhas; i++) {
        int colunas = X[0].size();
        for (int j = 0; j < colunas; j++) cout << X[i][j] << "\t";
        cout << endl;
    }
}

int main() {
	vector<vector<double>> X {
	        {1.0, 2.0, 3.0,2.5},
	        {2.0, 5.0,-1.0,2.0},
	        {-1.5,2.7,3.3,-0.8}
	};
	imprime(X);
}

//https://pt.stackoverflow.com/q/451932/101
