if (!(errS & errE)) {
    fprintf(stderr, "\nFALTA ARGUMENTOS\n");
    if (!errS) fprintf(stderr, "-s NOME ARQUIVO SAIDA \n");
    if (!errE) fprintf(stderr, "-e NOME ARQUIVO ENTRADA \n");
    exit(1);
}

//https://pt.stackoverflow.com/q/288726/101
