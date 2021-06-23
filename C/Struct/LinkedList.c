typedef struct node {
    int value;
    struct node *next;
} Node;

Node *head = malloc(sizeof(Node));
if (head == NULL) {
    return 1;
}
head->value = 1;
head->next = NULL;

//https://pt.stackoverflow.com/q/170420/101
