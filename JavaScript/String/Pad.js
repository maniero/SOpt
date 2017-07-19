function padRight(str, len, char) {
    if (typeof(char) === 'undefined') {
        char = ' ';
    }
    len = len + 1 - str.length
    len = len  > 0 ? len : 0
    return Array(len).join(char) + str;
}

function padLeft(str, len, char) {
    if (typeof(char) === 'undefined') {
        char = ' ';
    }
    len = len + 1 - str.length
    len = len  > 0 ? len : 0
    return str + Array(len).join(char);
}

console.log(padLeft("teste", 8));
console.log(padLeft("teste", 8, '_'));
console.log(padLeft("teste e mais teste", 8, '_'));
console.log(padRight("teste", 8));
console.log(padRight("teste", 8, '_'));
console.log(padRight("teste e mais teste", 8, '_'));

//https://pt.stackoverflow.com/q/221601/101
