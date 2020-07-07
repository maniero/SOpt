function busca(array, numero) {
    for (var i = 0; i < array.length; i++) if (array[i] % numero == 0 && array[i] != 0) return array[i];
}

console.log(busca([0, 7, 4, 15, 18, 3, -1, 323, -5], 2));

//https://pt.stackoverflow.com/q/461011/101
