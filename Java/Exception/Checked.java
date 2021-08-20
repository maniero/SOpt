public void teste() throws AlgumaException {
    //faz alguma coisa
    if (condicao) throw new AlgumaException();
    //faz alguma coisa
}

public void teste2() throws AlgumaException {
    //faz alguma coisa
    teste();
    //faz alguma coisa
}

public void teste() {
    try {
        //faz alguma coisa
    } catch (AlgumaException ex) {
        //faz alguma coisa
    }
}

//https://pt.stackoverflow.com/q/214768/101
