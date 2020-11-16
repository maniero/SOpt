if (!int.TryParse(txtIdComanda.Text out var id) {
    //faz alguma coisa para indicar que deu erro e não permite continuar
}
if (!short.TryParse(txtMesa.Text out var mesa) {
    //faz alguma coisa para indicar que deu erro e não permite continuar
}
if (!decimal.TryParse(txtValorProduto.Text out var valor) {
    //faz alguma coisa para indicar que deu erro e não permite continuar
}
cmd.Add(new Comanda {
    idComanda = id), 
    nMesa = mesa,
    produto = new Produto() {
        nomeProduto = cbxProduto.Text,
        valorUnitario = valor
    }
});

//https://pt.stackoverflow.com/q/482280/101
