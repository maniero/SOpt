private void btnenviar_Click(object sender, EventArgs e) {
    if(mskTxtplaca.Text != "" && cbxmarca.Text != "" && txtanofabricacao.Text != "") {
        veiculos.Placa = mskTxtplaca.Text;
        veiculos.Marca = cbxmarca.Text;
        if (int.TryParse(txtanofabricacao.Text, out var anoFabricacao) {
            veiculos.AnoFabricacao = anoFabricacao;
        } else {
            //aqui coloque o que deve fazer se a conversão falhar
        }
    }
}

//https://pt.stackoverflow.com/q/160334/101
