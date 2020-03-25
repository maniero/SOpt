function arrayMax(array) {
    var max = -Infinity;
    for (i = 0; i != array.length; ++i) {
        if (array[i] > max) {
            max = array[i];
        }
    }
    return max;
}
console.log(arrayMax([5, 8, 2, 3, 6, 1]));

//https://pt.stackoverflow.com/q/169503/101
