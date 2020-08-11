function testa(e, i) {
    for (var j = 0; j < e.length; j++) if (e[j] == i) return true;
    return false;
}
var e = [10, 20, 30, 40, 50];
for (var i = 0; i <= 50; i++) {
    if (testa(e, i)) document.write("O numero escolhido é: " + i + "<br />");
    else document.write("O numero NÃO escolhido é: " + i + "<br />");
}

//https://pt.stackoverflow.com/q/337215/101
