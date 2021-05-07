#include <stdlib.h>
#include <stdio.h>
#include <stdint.h>

void a(uint8_t **po, size_t t) {
    *po = realloc(*po, t);
}

int main() {
    uint8_t *array = NULL;
    a(&array, sizeof(uint8_t) * 2);
    array[0] = 1;
    array[1] = 3;
}

//https://pt.stackoverflow.com/q/508193/101
