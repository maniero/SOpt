private void textBox1_Leave(object sender, EventArgs e) {
    TextBox textBoxTemp = (TextBox)sender;
    MessageBox.Show("Você digitou: " + textBoxTemp.Text);
}

private void textBox1_Leave(object sender, EventArgs e) {
    TextBox textBoxTemp = sender as TextBox;
    if (textBoxTemp != null) {
        MessageBox.Show("Você digitou: " + textBoxTemp.Text);
    }
}

private void textBox1_Leave(object sender, EventArgs e) {
    TextBox textBoxTemp = sender as TextBox;
    MessageBox.Show("Você digitou: " + textBoxTemp?.Text);
}

if (sender is TextBox) {
    TextBox sender = (TextBox) textBoxTemp;
    //faz algo aqui
}

private void textBox1_Leave(object sender, EventArgs e) {
    if (textBoxTemp isTextBox textBoxTemp) {
        MessageBox.Show("Você digitou: " + textBoxTemp.Text);
    }
}

//https://pt.stackoverflow.com/q/47935/101
