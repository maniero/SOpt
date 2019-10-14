#include <stdio.h>
#include <stdlib.h>

typedef struct node *link;

struct node {
    int item;
    link next;
};

int main(void) {
    link l = malloc(sizeof(struct node));
    l->next = NULL;
}

//https://pt.stackoverflow.com/q/90496/101
