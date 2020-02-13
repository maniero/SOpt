void MemCpyX(char *as_origem, char *ls_retorno, int an_inicio, int an_quantidade) {
    memcpy(ls_retorno, as_origem + an_inicio, an_quantidade);
}

char *retorno = malloc(quantidade);
MemCpyX(origem, retorno, inicio, quantidade);
//faz alguma coisa
free(retorno);

//https://pt.stackoverflow.com/q/143017/101
