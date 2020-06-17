function fatorial(numero) {
    let num = 1;
    for (let i = numero; i > 1; i--) {
        num *= i;
    }
    return num;
}
console.log(fatorial(5));

//https://pt.stackoverflow.com/q/457749/101
