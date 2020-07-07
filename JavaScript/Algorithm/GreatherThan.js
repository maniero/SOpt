function maiorNumero(array, numero) {
    var novo = [];
    for(var i = 0; i < array.length; i++) if (array[i] > numero) novo.push(array[i]);
    return novo;
}

console.log(maiorNumero([70, 2, 9, 65, 5, -1, 0, 89, -5], 7))

//https://pt.stackoverflow.com/q/460976/101
