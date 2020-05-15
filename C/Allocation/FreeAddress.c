#include <stdio.h>
#include <stdlib.h>

int main(void) {
    int *ponteiro1 = malloc(sizeof(int));
    *ponteiro1 = 5;
    int *ponteiro2 = ponteiro1;
    printf("%p == %p, %d == %d\n", (void *)ponteiro1, (void *)ponteiro2, *ponteiro1, *ponteiro2);
    free(ponteiro2);
    printf("%p == %p, %d == %d", (void *)ponteiro1, (void *)ponteiro2, *ponteiro1, *ponteiro2);
}

//https://pt.stackoverflow.com/q/451825/101
