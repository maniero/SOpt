function funcao1(cb, message) {
    return cb(message);
}

function funcao2(message) {
    console.log(message);
}

funcao1(funcao2, "ok");

//https://pt.stackoverflow.com/q/470439/101
