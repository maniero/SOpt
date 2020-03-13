char* endereca(Pessoa* pessoa) {
    if (pessoa->sexo == 'M')  {
        char *msg = malloc(8 + sizeof(pessoa->nome));
        msg = strcat("Ao Sr.:\n", pessoa->nome);
    }
}

//https://pt.stackoverflow.com/q/158049/101
