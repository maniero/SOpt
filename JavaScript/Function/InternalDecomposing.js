function funcao(parametro) {
    var variavel = 1;
    return parametro + variavel * 2;
}
var x = 4;
console.log(funcao(x + 3));


function funcao() {
    var variavel = 1;
    return parametro + variavel * 2;
}
x = 4;
parametro = x + 3;
console.log(funcao());


function funcao(parametro) {
    var variavel = 1;
    console.log(x); // <========= idealmente não deveria ser acessível aqui
    return parametro + variavel * 2;
}
var x = 4;
console.log(funcao(x + 3));


function funcao(parametro) {
    parametro.a = 3;
    return parametro.a + parametro.b;
}
var x = { a : 1, b : 2 };
console.log(funcao(x));
console.log(x.a);

//https://pt.stackoverflow.com/q/163079/101
