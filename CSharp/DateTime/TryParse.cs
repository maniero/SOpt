DateTime dataInicio;
if (!DateTime.TryParse(textbox_inicio.Text, out dataInicio)) {
    lblErro.Text =  "Formato da data inicial é inválido";
    lblErro.Visible = true;
    return;
}
DateTime dataFim;
if (!DateTime.TryParse(textbox_fim.Text, out dataFim)) {
    lblErro.Text =  "Formato da data final é inválido";
    lblErro.Visible = true;
    return;
}

if (DateTime.Compare(dataInicio.Date > dataFinal.Date) {
    lblErro.Text = "Data inicial não pode ser superior à data final";
    lblErro.Visible = true;
} else {
    lblErro.Text = "";
    lblErro.Visible = false;
}

//https://pt.stackoverflow.com/q/41620/101
