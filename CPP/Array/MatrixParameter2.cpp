#include<iostream>
#include <vector>
using namespace std;

void recebeValor(vector<vector<int>> mat) {
   mat[0][0] = 2;
   cout << mat[0][0];
}

int main() {
	cout << "Entre o numero de linhas da matriz A: ";
	int lin;
	cin >> lin;
	cout << "Entre o numero de colunas da matriz A> ";
	int col;
	cin >> col; 
	vector<vector<int>> mat(lin, vector<int>(col));
	recebeValor(mat);
}

//https://pt.stackoverflow.com/q/99941/101
