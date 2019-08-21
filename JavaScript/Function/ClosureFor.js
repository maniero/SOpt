for (var index = 0; index <= 3; index++) {
    console.log(index); //varia de 0 até 3 porque esses valores dão condição verdadeira
    console.log(index <= 3);
    setTimeout(function() {
        console.log(index)
    }, 1000);
}
console.log("fora do for");
console.log(index); //houve 4 incrementos chegando neste número
//quando começa em 0 e vai incrementando a única forma de dar falso aqui é chegando no 4
console.log(index <= 3);
console.log("1 segundo depois vai executar o abaixo");
//note que não tem código aqui, é o setTimeout() que vai chamar a função com closure

for (var index = 0; index <= 3; index++) {
    function timer(i) {
        setTimeout(function() {
            console.log(i)
        }, 1000)
    };
    timer(index);
}

for (let index = 0; index <= 3; index++) {
    setTimeout(function() {
        console.log(index)
    }, 1000);
}

//https://pt.stackoverflow.com/q/404127/101
