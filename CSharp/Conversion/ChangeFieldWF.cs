private void txtCalcular_TextChanged(object sender, EventArgs e) {
    if (!double.TryParse(txtCalcular.Text, out var resultado)) {
        //faça alguma coisa aqui para indicar que houve erro de digitação;
        return;
    }
    txtCalcular.Text = (resultado * 9.81).ToString());
}

//https://pt.stackoverflow.com/q/525032/101
