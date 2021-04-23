function retornaIndiceMaiorValor() {
    let maior = array[0];
    let indice = 0;
    for (let i = 1; i < array.length; i++) {
        if (array[i] > maior) {
            maior = array[i];
            indice = i;
        }
    }
    return indice;
}

let array = [2, 3, 6, 7, 10, 1];
console.log(retornaIndiceMaiorValor(array));

//https://pt.stackoverflow.com/q/436409/101
