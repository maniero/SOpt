decimal valorDecimal;
if (decimal.TryParse(txtValor.Text, out valorDecimal)) {
    meuVen.Valor = valorDecimal; //note que você quer atribuir o resultado a uma variável
} else {
    //faz um tratamento de erro aqui
}

//https://pt.stackoverflow.com/q/86684/101
