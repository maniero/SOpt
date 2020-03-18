function temValor(array) {
    for (var i = 0; i < array.length; i++) if (array[i] >= 2) return true;
    return false;
}
var array = [0, 5, 1, 2];
console.log(temValor(array));


function temValor(array, limite) {
    for (var i = 0; i < array.length; i++) if (array[i] >= limite) return true;
    return false;
}
var array = [0, 5, 1, 2];
console.log(temValor(array, 2));

//https://pt.stackoverflow.com/q/162676/101
