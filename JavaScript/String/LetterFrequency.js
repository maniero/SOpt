 function letter_frequency(s) {
    let arr = [];
    for (let chave in s) {
        let char = s[chave].toUpperCase();
        if (arr[char] !== undefined) arr[char]++;
        else arr[char] = 1;
        for (let chave in arr) console.log(chave, "=>", arr[chave]);
        console.log("------");
    }
    return arr;
}

letter_frequency("Hello World");

//https://pt.stackoverflow.com/q/414244/101
