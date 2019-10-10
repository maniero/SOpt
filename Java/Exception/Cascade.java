try {
    //faz coisas aqui
} catch (SpecificException ex) {
    //faz algo para se recuperar da falha ou indicar o erro em log ou tela
    // só entrar aqui se uma exceção deste tipo ou derivada dela for lançada no bloco try
} catch (OtherSpecificException ex) {
    //faz algo para se recuperar da falha ou indicar o erro em log ou tela
    // só entrar aqui se uma exceção deste tipo ou derivada dela for lançada no bloco try
} catch (SpecificPeroNoMuchoException ex) {
    //faz algo para se recuperar da falha ou indicar o erro em log ou tela
    // só entrar aqui se uma exceção deste tipo ou derivada dela for lançada no bloco try
} catch (Exception ex) {
    //Indicar o erro em log ou tela
    // só entrar aqui se uma exceção deste tipo ou derivada dela for lançada no bloco try
} finally {
    //aqui executa no final lançando exceção ou não
}

//https://pt.stackoverflow.com/q/88923/101
