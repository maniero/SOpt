function validaSenha() {
    var erros = 0;
    while (true) {
        if (prompt("Entre com sua senha: ") == "1234") {
            document.write("Acesso Liberado");
            break;
        } else if (++erros == 3) {
            document.write("Conta bloqueada");
            return;
        } 
    }
    //aqui faz algo para o caso da liberação
}
validaSenha();

//https://pt.stackoverflow.com/q/351418/101
