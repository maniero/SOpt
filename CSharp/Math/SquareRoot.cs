private void buttonRaiz_Click(object sender, EventArgs e) { 
    if (!double.TryParse(label1, out var valor) //faz alguma coisa aqui para indicar erro
    Tela.Text = Math.Sqrt(valor).ToString();
}

//https://pt.stackoverflow.com/q/391436/101
