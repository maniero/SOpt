var numero = Number(prompt('Número: '));
var seguintes = '';
for (var i = 1; i < 10; i++) seguintes += numero + i + ', ';
seguintes += numero + 10;
console.log(`Seguintes: ${seguintes}`);

//https://pt.stackoverflow.com/q/446026/101
