let valor: any;
valor = 1;
let numero : number = valor;
valor = "SOpt";
valor.toUpperCase();
valor = [];
valor = {};
//valor.toUpperCase(); //tire o comentário para ver o erro em tempo de execução
console.log(numero);

let valor: unknown;
valor = 1;
//let numero : number = valor; //isso dá erro em compilação
let numero : number = valor as number;
console.log(valor); //compila e funciona
valor = "SOpt";
//valor.toUpperCase(); //isso daria erro em compilação
if (typeof valor === "string") console.log(valor.toUpperCase()); //compila e funciona
valor = [];
valor = {};

//https://pt.stackoverflow.com/q/427010/101
