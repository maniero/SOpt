function imprimir() {
    console.log('Funcão que chamou: ', arguments.callee.caller.name)
}

function criarEvento() {
    imprimir(); //os argumentos são irrelevantes para o problema
}

criarEvento();


function oNomeDessaFuncao() {}

function imprimir(nomeFuncao) {
    console.log('Funcão passada: ', nomeFuncao.toString());
}

function criarEvento() {
    imprimir(oNomeDessaFuncao);
}

criarEvento();

//https://pt.stackoverflow.com/q/162821/101
