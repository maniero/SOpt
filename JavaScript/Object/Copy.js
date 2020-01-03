var a = {a: 1, b: 2};

var b = a;
b.a = 3; 
document.body.innerHTML += a.a; //imprime 3

function change(objeto) {
    objeto.a = 3;
}

change(a);
document.body.innerHTML += a.a; //imprime 3

function copy(objeto) {
    return objeto;
}

var b = copy(a);
b.a = 3;
document.body.innerHTML += a.a; //imprime 3

//https://pt.stackoverflow.com/q/125816/101
