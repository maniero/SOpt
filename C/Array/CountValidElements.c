void ReposicionaObjetos(){
    int contaElementosValidos = 0;
    memset(marcadoresVisiveis, 0, sizeof marcadoresVisiveis);
    for int (i = 0; i < config->marker_num; i++) {
        if (config->marker[i].visible >= 0 ){
            marcadoresVisiveis[i] = config->marker[i];
            contaElementosValidos++;
        }
    }
    //faz o que precisa com contaElementosValidos
}

//https://pt.stackoverflow.com/q/200975/101
