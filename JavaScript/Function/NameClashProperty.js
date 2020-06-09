class Teste {
    static teste() {
        return 1;
    }
    constructor() {
        this.teste = 2;
    }
}

var x = new Teste();
console.log(x.teste);
console.log(Teste.teste());

//https://pt.stackoverflow.com/q/231167/101
