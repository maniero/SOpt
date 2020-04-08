function send(name) { //recebe um parâmetro que não deixa de ser uma variável
    return function () { //ainda estamos dentro da outra função
        sendHi(name); //aquela variável é acessível aqui
    }
}
//este é um caso diferenteé uma variável que se mantêm dentro do escopo

function sendHi(msg) {
    console.log('Hello ' + msg);
}

var func = send('Bill'); //aqui a variável recebe como valor uma função
func(); //chama a variável como a função
sendHi('Pete'); // //chama diretamente a outra função
func();

//https://pt.stackoverflow.com/q/175434/101
