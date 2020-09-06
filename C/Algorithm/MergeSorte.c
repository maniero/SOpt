#include <stdio.h> 
#include <stdlib.h> 
  
void merge(int array[], int l, int m, int r) { 
    int n1 = m - l + 1; 
    int n2 = r - m; 
    int left[n1], right[n2];
    for (int i = 0; i < n1; i++) left[i] = array[l + i]; 
    for (int j = 0; j < n2; j++) right[j] = array[m + 1 + j]; 
    int i = 0;
    int j = 0;
    int k = l;
    while (i < n1 && j < n2) { 
        if (left[i] <= right[j]) array[k] = left[i++]; 
        else array[k] = right[j++]; 
        k++; 
    } 
    while (i < n1) array[k++] = left[i++]; 
    while (j < n2) array[k++] = right[j++]; 
} 
  
void mergeSort(int array[], int l, int r) { 
    if (l < r) { 
        int m = l + (r - l) / 2; 
        mergeSort(array, l, m); 
        mergeSort(array, m + 1, r); 
        merge(array, l, m, r); 
    } 
} 
  
void printArray(int array[], int size) { 
    for (int i = 0; i < size; i++) printf("%d ", array[i]); 
    printf("\n"); 
} 
  
int main() { 
    int array[] = { 14, 21, 33, 15, 6, 17, 9, 28 }; 
    int size = sizeof(array) / sizeof(array[0]); 
    printArray(array, size); 
    mergeSort(array, 0, size - 1); 
    printArray(array, size); 
}

//https://pt.quora.com/unanswered/Como-fazer-o-c%C3%B3digo-MergeSort-em-C
