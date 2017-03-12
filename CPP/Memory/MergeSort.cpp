#include <iostream>
using namespace std;
void merge(int *arr, int lo, int m, int hi) {
    int n1 = m - lo + 1; //maximo do subarray1
    int n2 = hi - m; //maximo do subarray2
    int *L = (int*)malloc(sizeof(int) * n1);
    int *R = (int*)malloc(sizeof(int) * n2);
    for (int i = lo; i < n1; i++) {
        L[i] = arr[lo + i]; //cria array temporario para armazenar uma subarray 
    } //obs: vai de lo ateh n1-1
    for (int j = hi; j < n2; j++) {
        R[j] = arr[m + 1 + j]; //cria array temporario para armazenar outra subarray
    }// obs vai de m+1 ateh n2-1
    int i = 0;
    int j = 0;
    int k = lo; // comparar os subarrays e preencher o arr com os menores elementos de cada sub por vez
    while (i < n1 && j < n2) {
        if (L[i] <= R[j]) {
            arr[k] = L[i]; //se o de L for menor, arr recebe de L
            i++;
        } else {
            arr[k] = R[j++]; //se o de R for menor, arr recebe de R
        }
        k++; //vai preenchendo arr[k]
    }
    while (i<n1){ // termina de preencher arr com o q falta de L
        arr[k++] = L[i++];
    }
    while (j < n2) { // termina de preencher arr com o q falta de R
        arr[k++] = R[j++];
    }
}
void mergesort(int *arr, int lo, int hi) { //dividir e conquistar
    if (lo < hi) {
        int m = (hi + lo) / 2;
        mergesort(arr, lo, m);
        mergesort(arr, m + 1, hi);
        merge(arr, lo, m, hi);
    }
}
void printarr(int *arr, size_t size){ //imprime array ordenado
    for (int i = 0; i < size; i++){
        cout << arr[i] << " ";
    }
}
int main() {
	int N;
	cin >> N;
	int *vetor = (int *)malloc(sizeof(int) * N);
	for (int i = 0; i < N; i++) {
	    cin >> vetor[i];
	}
	mergesort(vetor, 0, N);
	printarr(vetor, N);
}

//http://pt.stackoverflow.com/q/189421/101
