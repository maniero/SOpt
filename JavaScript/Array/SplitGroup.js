let texto = "1789, 3, 8 , 1788, 3, 8, 1790, 3, 9";
let array = new Array();
let quebrado = texto.split(",");
for (let i = 0; i < quebrado.length; i+= 3) array.push([parseInt(quebrado[i]), parseInt(quebrado[i + 1]), parseInt(quebrado[i + 2])]);
console.log(array);

//https://pt.stackoverflow.com/q/424121/101
