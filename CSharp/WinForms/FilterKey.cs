private void textBox11_KeyPress(object sender, KeyPressEventArgs e) {
    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) {
        e.Handled = true;
        MessageBox.Show("este campo aceita somente numero e virgula");
    }
    if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
        e.Handled = true;
        MessageBox.Show("este campo aceita somente uma virgula");
    }
}

//https://pt.stackoverflow.com/q/149885/101
