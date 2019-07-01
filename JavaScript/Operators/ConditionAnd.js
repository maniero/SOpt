let valorModulo1;
let permissoes = new Array(36);
for (let i = 0; i < 36; i++) permissoes[i] = "0";

if (permissoes[0] == "0" && permissoes[5] == "0" && permissoes[10] == "0" && permissoes[15] == "0" && permissoes[20] == "0" && permissoes[25] == "0" && permissoes[30] == "0" && permissoes[35] == "0") {
    valorModulo1 = "0";
} else {
    valorModulo1 = "1";
}

console.log(valorModulo1);
permissoes[0] = "1";

if (permissoes[0] == "0" && permissoes[5] == "0" && permissoes[10] == "0" && permissoes[15] == "0" && permissoes[20] == "0" && permissoes[25] == "0" && permissoes[30] == "0" && permissoes[35] == "0") {
    valorModulo1 = "0";
} else {
    valorModulo1 = "1";
}

console.log(valorModulo1);

//https://pt.stackoverflow.com/q/393932/101
