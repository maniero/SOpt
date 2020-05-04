#include <stdio.h>
#include <stdlib.h>

struct Node {
    int data;
    struct Node *next;
};

typedef struct Node *No;
typedef struct Node Elem;

void push1(struct Node** headRef, int data) {
    struct Node* newNode = malloc(sizeof(struct Node));
    newNode->data = data;
    newNode->next = *headRef;
    *headRef = newNode;
}

No *push2(No *li, int data) {
    Elem *no = malloc(sizeof(Elem));
    no->data = data;
    no->next = (*li);
    *li = no;
    return li;
}

int main() {
    int arr[] = {1, 2, 3};
    int i = 0;
    struct Node *head = NULL;
    push1(&head, arr[i]);
    printf("%d", head->data);
    No *li = malloc(sizeof(No));
    No *result = push2(li, arr[i]);
    printf("%d", (*li)->data);
    printf("%d", (*result)->data);
}

//https://pt.stackoverflow.com/q/449408/101
