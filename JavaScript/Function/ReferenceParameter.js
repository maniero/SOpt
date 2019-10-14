function apontador(texto) {
   return "funcionou :D";
}
var str = "teste";
str = apontador(str);
console.log(str);

function apontador(texto) {
   return ["funcionou :D", "Outro texto " + texto];
}
var str = "teste";
var objeto = apontador(str);
console.log(objeto[0]);

function apontador(objeto) {
   objeto[0] = "funcionou :D";
}
var str = "teste";
var objeto = [str];
apontador(objeto);
console.log(objeto[0]);

//https://pt.stackoverflow.com/q/415782/101
