function Somar(array) {
    var total = 0;
    for (var i = 0; i < array.length; i++) {
        if (array[i] >= 2) {
            total += array[i];
        }
    }
    return total;
}
var array = [0, 5, 1, 2];
console.log(Somar(teste));


function Somar(array, limite) {
    var total = 0;
    for (var i = 0; i < array.length; i++) {
        if (array[i] >= limite) {
            total += array[i];
        }
    }
    return total;
}
var array = [0, 5, 1, 2];
console.log(Somar(array, 2));


function Somar(array, limite) {
    for (var i = 0, total = 0; i < array.length; (total += array[i] >= limite ? array[i] : 0), i++);
    return total;
}
console.log(Somar([0, 5, 1, 2], 2));

//https://pt.stackoverflow.com/q/162708/101
