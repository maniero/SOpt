#include <stdio.h>
#include <stdlib.h>

int compare(const void* left, const void* right) { return (*(int*)right - *(int*)left); }
int main() {
    int (*cmp) (const void* , const void*) = &compare;
    int array[] = {1, 8, 0, 4, 6, 5, 1, 6, 9, 7};
    qsort(array, 10, sizeof(int), cmp);
    for (int i = 0; i < 10; i++) printf("%d ", array[i]);
}

//https://pt.stackoverflow.com/q/322422/101
