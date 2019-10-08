do {
    try funcao()
    //faz algo aqui
} catch TipoErro.ErroEspecifico { //pega exceção específica
    //faz algo aqui
} catch TipoErro.ErroEspecifico where x == 0 { //exceção filtrada
    //faz algo aqui
} catch { //pega qualquer exceção não especificada anteriormente
    //faz algo aqui
}

//https://pt.stackoverflow.com/q/87926/101
