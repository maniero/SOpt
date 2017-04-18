void imprime(lista* recebida) {
    lista* aux = recebida;
    while (aux!=NULL) {
        printf("Informacao %d\n",aux->info);
        aux=aux->prox;
    }
}

//https://pt.stackoverflow.com/q/199021/101
