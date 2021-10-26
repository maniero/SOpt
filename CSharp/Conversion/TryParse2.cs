if (int.TryParse(SalvarCodigo.Text, var out codigo)) { //<=======note o .Text aqui
    var d = new Crud();
    d.Atualizar(new Contato(codigo, SalvarNome.Text, SalvarFone.Text, SalvarEmail.Text));
    Message.Text = "Cadastro alterado com sucesso";
} else {
    //aqui trata se o código é inválido
}

//https://pt.stackoverflow.com/q/165613/101
