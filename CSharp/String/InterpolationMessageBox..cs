private void Button1_Click(object sender, EventArgs e) {
    if (!int.TryParse(txtAA.Text, out var anoAtual || !int.TryParse(txtAC.Text, out var anoAtual) {
        MessageBox.Show("Ano inválido não é possível continuar", "Mensagem");
        return;
    }
    int resultado = anoAtual - anoCasamento;
    switch (resultado) {
    case 25:
        MessageBox.Show("25 anos de casado! BODAS DE PRATA!", "Mensagem");
        break;
    case 50:
        MessageBox.Show("50 anos de casado! BODAS DE OURO!", "Mensagem");
        break;
    case 75:
        MessageBox.Show("75 anos de casado! BODAS DE DIAMANTE!", "Mensagem");
        break;
    default:
        MessageBox.Show($"{resultado} anos de casado", "Mensagem"); // Aqui que está a minha dúvida
    }
}

//https://pt.stackoverflow.com/q/404741/101
