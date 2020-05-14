private void mudaCorBotao(Button bt) {
    foreach(Control b in Panel_esq.Controls) {
        if (b is Button) {
            b.BackColor = SystemColors.HotTrack;
            b.ForeColor = Color.White;
        }
    }
    bt.BackColor = Color.White;
    bt.ForeColor = Color.Black;
}

//https://pt.stackoverflow.com/q/199971/101
