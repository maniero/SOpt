#include <stdio.h>

void tarefa(int r) {
    for (int e = 1; e <= r; e++) printf(" %d  ", r);
}


int main(int argc, char *argv[]) {
    int x;
    scanf("%d", &x);
    for (int j = 0; j <= x; j++) tarefa(j);  
}

//https://pt.stackoverflow.com/q/239574/101
