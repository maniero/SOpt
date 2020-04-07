if (long.TryParse(txtCaixa1.Text, out var valor)) {
    //aqui faz o que deseja se a conversão foi bem sucedida, provavelmente:
    valores[0] = valor;
} else {
    //faça aqui o que deseja, se o valor é inválido, quem sabe:
    valores[0] = 0;
}

//https://pt.stackoverflow.com/q/174943/101
