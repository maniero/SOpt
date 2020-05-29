class Veiculo {
    locomover() { ... } 
    parar() { ... } 
    ligarLanternas() { ... } 
}

class Carro extends Veiculo {
    travarPortas() { ... } //especialização porque é característica própria

    locomover() { ... } //especialização porque o comportamento é próprio
    parar() { ... } //tudo aqui é diferente do implementado na classe generalizada
    //note que ligarLanternas() não foi especializado, o comportamento é o geral mesmo
}

//https://pt.stackoverflow.com/q/219950/101
