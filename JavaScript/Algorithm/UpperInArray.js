function transformaParaMaiusculo(palavras) {
    var novo = [];
    for(var i = 0; i < palavras.length; i++) novo.push(palavras[i].toUpperCase());
    return novo;
}

console.log(transformaParaMaiusculo(["arroz", "blusa", "lápis"]))

//https://pt.stackoverflow.com/q/460980/101
