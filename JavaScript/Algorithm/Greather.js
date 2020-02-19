function retornaMaiorValor() {
    var maior = 0;
    for (let i = 0; i < array.length; i++) if (array[i] > maior) maior = array[i];
    return maior;
}

let array = [2, 3, 6, 7, 10, 1];
console.log(retornaMaiorValor(array));

//https://pt.stackoverflow.com/q/436409/101
