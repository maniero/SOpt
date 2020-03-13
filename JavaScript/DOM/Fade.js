var fadeJaExecutado = false;

if (!fadeJaExecutado) {
    //faz o que tem que fazer
    fadeJaExecutado = true;
}

var fadeExecutando = false;

function fade() {
    if (!fadeExecutando) {
        fadeIn();
        fadeExecutando = true;
    } else {
        fadeOut();
        fadeExecutando = false;
    }
}

//https://pt.stackoverflow.com/q/158462/101
