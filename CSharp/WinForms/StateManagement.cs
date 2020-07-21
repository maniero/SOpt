private int tentativasErradas = 0;

private void btnEntrar_Click(object sender, EventArgs e) {
    if (senha != "") {
        if (txtVerifica.Text == senha) {
            Form desenvolvimento = Application.OpenForms.OfType<Desenvolvimento>().Any() ? Application.OpenForms["Desenvolvimeto"] : new Desenvolvimento();
            desenvolvimento.Show();
            this.Hide();
       } else {
            if (tentativasErradas == 3) {
                MessageBox.Show("Três tentativas !");
                Application.Exit();
            } else {
                tentativasErradas++;
                MessageBox.Show("Senha inválida !");
            }
        }
    } else {
        MessageBox.Show("Cadastre uma senha !");
        txtSenha.Focus();
    }
}

//https://pt.stackoverflow.com/q/301806/101
