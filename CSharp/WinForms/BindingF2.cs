private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
    if (e.KeyCode == Keys.F2) {
        //sua rotina aqui
        OPERACOES OP = new OPERACOES();
        OP.ShowDialog();
    }
}

//https://pt.stackoverflow.com/q/88447/101
