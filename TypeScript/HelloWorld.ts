class Hello {
    quem: string;
    constructor (mensagem: string) {
        this.quem = mensagem;
    }
    Diga() {
        return "Olá, " + this.quem;
    }
}

//Compila para (depende de versão):

var Hello= (function () {
    function Hello(mensagem) {
        this.quem= mensagem;
    }
    Hello.prototype.Diga = function () {
        return "Olá, " + this.quem;
    };
    return Hello;
})();

//http://pt.stackoverflow.com/q/15998/101
