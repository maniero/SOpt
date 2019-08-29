function teste(oi, type) {
    oi = (typeof(oi) === "undefined" || oi === null) ? "ola" : oi;
    type = (typeof(type) === "undefined" || oi === null) ? 1 : type;
    //continua a função aqui

function def(variable, value) {
    return (typeof(variable) === "undefined" || === null) ? value : variable;
}

Aí usaria assim:

function teste(oi, type) {
    oi = def(oi, "ola");
    type = def(type, 1);
}

//https://pt.stackoverflow.com/q/56710/101    
