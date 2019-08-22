function criaFuncao() {
    return function() { console.log("oi"); };
}
var codigo = criaFuncao();
codigo(); // vai imprimir oi

//https://pt.stackoverflow.com/q/55204/101
