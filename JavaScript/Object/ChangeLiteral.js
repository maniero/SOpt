var cliente = {
    nome: "Wesley",
    idade: 20,
    cargo: "Front End",
    setAtualiza : function(n, i, c) { //tinha um erro de digitação aqui.
        this.nome = n;
        this.idade = i;
        this.cargo = c
    }
};

cliente.setAtualiza("NovoNome", 25, "Pleno"); //a chamada deve ser contextual
for (var x in cliente) {
    console.log(cliente[x]); //mudei aqui só executar certo no SO, pode manter o seu
};

//https://pt.stackoverflow.com/q/58181/101
