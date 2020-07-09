for (LancamentoCaixa lancamento : listaCaixaAbertos()) {
    lancamento.setFechado(true);
    salvar(lancamento);
}

//https://pt.stackoverflow.com/q/273587/101
