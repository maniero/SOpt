let x = 23;
let y = 10;
let temp = Math.trunc(x / y); //pega a parte inteira, então o 2,3 vira 2
let modulo = x - temp * y; //pega o dividendo menos o maior valor inteiro divisível
console.log(modulo);
console.log((17 - Math.trunc(17 / 5) * 5));
console.log((13 - Math.trunc(13 / 7) * 7));

//https://pt.stackoverflow.com/q/93092/101
