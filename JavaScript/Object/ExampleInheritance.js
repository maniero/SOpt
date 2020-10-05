class Banco {
    constructor(agencia, conta, saldo) {
        this.agencia = agencia;
        this.conta = conta;
        this.saldo = saldo;
    }
    exibir() {
        console.log(this.saldo);
    }
}

class NovoBanco extends Banco {
    exibirAgencia() {
        console.log(this.agencia);
    }
}

var exemplo = new NovoBanco('1111-1');
exemplo.exibirAgencia();

//https://pt.stackoverflow.com/q/475149/101
