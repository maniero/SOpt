function gen(min, max, excludeMin, excludeMax) {
    var value;
    do {
        value = Math.random() * (max - min) + min;
    } while (value > excludeMin && value < excludeMax)
    return value;
}
console.log(gen(1, 100, 10, 20));

//https://pt.stackoverflow.com/q/47163/101
