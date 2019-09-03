function isPrime(number) {
    var start = 2;
    while (start <= Math.sqrt(number)) if (number % start++ < 1) return false;
    return number > 1;
}
console.log(isPrime(13));

//https://pt.stackoverflow.com/q/57579/101
