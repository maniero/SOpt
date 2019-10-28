 //faz o que tem que fazer aqui (se é que tem algo mais)
 return ListaCartoes.Any(c => c.Codigo == cartaoParaAcesso)

if (Webservice.LiberaAcesso(informacoesAcesso)) {
    //faz algo aqui se tiver que fazer
} else {
    MessageBox.Show("CARTÃO JÁ ESTÁ EM USO");
}

//https://pt.stackoverflow.com/q/97842/101
