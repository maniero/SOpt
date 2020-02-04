var variavel = {
    'teste1':'1',
    'teste2':'2',
    'teste3':'3'
};
console.log(variavel.teste1); //acessando o membro
console.log(variavel['teste2']); //sintaxes diferentes, mas mesmo resultado
var variavel2 = { //é mais comum fazer desta forma, ainda que funcione igual
    teste1:'1',
    teste2:'2',
    teste3:'3'
};
console.log(variavel2.teste1); //sintaxes diferentes, mas mesmo resultado
console.log(variavel2['teste2']);

var variavel3 = ['1', '2', '3'];
console.log(variavel3[0]);

//https://pt.stackoverflow.com/q/138104/101
