public void Salva() => if (valida()) insereNoBanco();
private bool valida() {
    // valida campos
}
private void insereNoBanco() {
    // insere dados no banco
}

public void Salva() {
    Func<bool> valida = () => {
        // valida campos
    };

    Action insereNoBanco = () => {
        // insere dados no banco
    };
    if (valida()) insereNoBanco();
}

//https://pt.stackoverflow.com/q/89674/101
