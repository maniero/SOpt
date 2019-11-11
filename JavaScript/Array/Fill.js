function generateRange(n) {
    let range = [];
    for (let i = 0; i <= n; i++) range[i] = i + 1;
    return range;
}
console.log(generateRange(5));

console.log(Array.from({length: 5}, (v, k) => k + 1));

//https://pt.stackoverflow.com/q/420523/101
