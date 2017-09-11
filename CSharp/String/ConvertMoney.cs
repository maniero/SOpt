private void btn_cadastrar_Click(object sender, EventArgs e) {
    var mo = new Modelo();
    var con = new conexao(); //espero que esteja bem feito para não dar vazamento
    try {
        if (Decimal.TryParse(txt_valor.Text.Replace(',', '.'), out var valor) {
            mo.Data_Compra = txt_dcompra.Text;
            mo.Data_Alvo = txt_dalvo.Text;
            mo.Fornecedor = txt_fornecedor.Text;
            mo.Valor = valor;
            mo.Tipo = cbox_tipo.Text;
            mo.Pagamento = lbl_fiado.Text;
            mo.Data_Pagamento = txt_dpagamento.Text;
            con.cadastro(mo);
            txt_fornecedor.Text = "";
            txt_valor.Text = "";
            MessageBox.Show("Dados gravados com sucesso!");
    } catch (MySqlException ex) { //capture uma exceção mais específica
        MessageBox.Show("Falha ao salvar no banco de dados :" + ex);
    }
}

//https://pt.stackoverflow.com/q/236279/101
