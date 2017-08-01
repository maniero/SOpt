function sayhello() {
    this.init = function() {
        console.log('Hello');
    }
}

function iniciaClasse(nomeDaClasse) {
    var funcao = window[nomeDaClasse];
    return new funcao();
}

var variavelqualquer = iniciaClasse('sayhello');

//https://pt.stackoverflow.com/q/225069/101
