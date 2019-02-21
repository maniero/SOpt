//seria bom verificar se recebeu null antes de usar o valor
console.log(gen(1, 100, 10, 20));

function gen(min, max, excludeMin, excludeMax){
    if (min > max || excludeMin > excludeMax) return null;
    var value;
    do {
        value = Math.random() * (max - min) + min;
    } while(value > excludeMin && value < excludeMax)
    return value;
}

//https://pt.stackoverflow.com/q/47163/101
