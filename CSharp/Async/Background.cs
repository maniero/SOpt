private async void buttonGeraBoletos_Click(object sender, EventArgs e) {
    await Task.Run(() => GeraBoletos());
    MessageBox.Show("Tudo gerado");
}

//https://pt.stackoverflow.com/q/162450/101
