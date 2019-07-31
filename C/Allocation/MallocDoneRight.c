#include <stdio.h>
#include <stdlib.h> 

int *f(int *ptr) {
    //faz alguma coisa com ptr aqui
    //do jeito que estava aqui, uma chamada do jeito errado criaria confusão
    //ainda não está ideal mas o exemplo todo não está
    return ptr;
}

void g(int *ptr) {
    //faz alguma coisa com ptr aqui
    return;
}

int main(void) {
    int tamanho = 5;
    //o importante é que o malloc agora está próximo do free, fica mais fácil acompanhar
    int *ponteiro = malloc(tamanho * sizeof *ponteiro); 

    g(f(ponteiro));

    if(ponteiro != NULL) { //só isto não garante nada em um exemplo mais completo
        free(ponteiro); //não é difícil associar este free ao malloc logo acima
    } else {
        puts("Memória insuficiente.");      
    }
}

//https://pt.stackoverflow.com/q/51613/101
