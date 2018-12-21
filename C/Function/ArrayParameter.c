#include <stdio.h>

char getVector(char vector[], int pos) {
    return vector[pos];
}

int main() {
    char vector[5] = {'V', 'e', 't', 'o', 'r'};
    printf("%c", getVector(vector, 0));
}

//https://pt.stackoverflow.com/q/44054/101
