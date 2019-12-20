private void textBox5_Click(object sender, EventArgs e) {  
    textBox5.ForeColor = Color.Black;
    textBox5.SelectAll();
    textBox5.Text = "";
    textBox5.Click -= textBox5_Click; //provavelmente isto
}

//https://pt.stackoverflow.com/q/122345/101
