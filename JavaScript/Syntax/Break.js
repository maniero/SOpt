var text = "";
fim: for (var i = 1; i <= 3; i++) {
    for (var j = 1; j <= 3; j++) {
        if (j === 3) break fim;
        text += "The number is " + j + "<br>";
    }
}
console.log(text);

function Finaliza() {
    var text = "";
    for (var i = 1; i <= 3; i++) {
        for (var j = 1; j <= 3; j++) {
            if (j === 3) return text;
            text += "The number is " + j + "<br>";
        }
    }
    return text;
}

console.log(Finaliza());

//https://pt.stackoverflow.com/q/273549/101
