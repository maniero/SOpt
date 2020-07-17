private void txtValorFinal_TextChanged(object sender, EventArgs e) {
    if (decimal.TryParse(txtValorFinal.Text, out var valorFinal) && decimal.TryParse(txtValorFornecedor.Text, out var valorFornecedor)) {
        txtLucro.Text = (valorFinal - valorFornecedor).ToString("0.00");
    } else {
        //tratar o erro aqui
    }
}

//essa classe Ado parece desnecessária ou mal formulada
var insert = new Ado("Data Source=DESKTOP-AJLR3DB\\SQLEXPRESS;Initial Catalog=DBGestor;Integrated Security=True");
insert.InsertProduto(txtNomeProduto.Text,
    //tem que fazer o mesmo do acima,
    cmbTipo.Text,
    //tem que fazer o mesmo do acima,
    //tem que fazer o mesmo do acima,
    //tem que fazer o mesmo do acima);
MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
    //e se der erro?
this.Close(); //duvido que isto está correto aqui
this.Dispose(); //quase certo que não deveria estar aqui

//o mais certo é receber um objeto com estas propriedades e não esse monte de parâmetro
public void InsertProduto(string nomeProduto, int quantidade, string tipo, decimal valorFornecedor, decimal valorFinal, decimal lucro) {
    using (var conn = new SqlConnection(ConectionString)) {
        conn.Open();
        //não sei o nome das colunas no banco de dados chuetei o que deveria ser
        var cmString = "INSERT INTO produtos (Nome, Quantidade, Tipo, ValorFornecedor, ValorFinal, Lucro) VALUES (@Nome, @Quantidade, @Tipo, @ValorFornecedor, @ValorFinal, @Lucro";
        var cmd = new SqlCommand(cmdString, conn);
        cmd.Parameters.AddWithValue("@Nome", nomeProduto);
        cmd.Parameters.AddWithValue("@Quantidade", quantidade);
        cmd.Parameters.AddWithValue("@Tipo", tipo);
        cmd.Parameters.AddWithValue("@ValorFornecedor", valorFornecedor);
        cmd.Parameters.AddWithValue("@ValorFinal", valorFinal);
        cmd.Parameters.AddWithValue("@Lucro", lucro);
        cmd.ExecuteNonQuery();
    }
}

//https://pt.stackoverflow.com/q/293843/101
