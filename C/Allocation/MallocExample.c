#include<stdio.h>
#include<stdlib.h>

void main() {
    int *ptr = malloc(4 * sizeof(int));
    int *temp = ptr;  
    for (int i = 0; i < 4; i++) {
         printf("\nEnter the Number %d : ", i);
         scanf("%d", temp++);
    }
    for (int i = 0; i < 4; i++) printf("\nNumber(%d) : %d", i, *ptr++);
}

//https://pt.stackoverflow.com/q/276547/101
