private void ChangePictureBoxes() {
    pictureBox1.Visible = false;
    pictureBox2.Visible = false;
    pictureBox3.Visible = false;
    pictureBox4.Visible = false;
    pictureBox5.Visible = false;
}

private void radioButton1_CheckedChanged(object sender, EventArgs e) {
    ChangePictureBoxes();
    pictureBox1.Visible = true;
}
private void radioButton2_CheckedChanged(object sender, EventArgs e) {
    ChangePictureBoxes()
    pictureBox2.Visible = true;
}
private void radioButton3_CheckedChanged(object sender, EventArgs e) {
    ChangePictureBoxes()
    pictureBox3.Visible = true;
}
private void radioButton4_CheckedChanged(object sender, EventArgs e) {
    ChangePictureBoxes()
    pictureBox4.Visible = true;
}
private void img5_CheckedChanged(object sender, EventArgs e) {
    ChangePictureBoxes()
    pictureBox5.Visible = true;
}

Eventualmente é possível usar o método utilitário da maneira como o Sunstreaker sugeriu, desde que você saiba que todos os PictureBox devem receber aquele estado. De fato se a semântica mais adequada é "todos PictureBoxes" ao invés de "os PictureBoxes tal e tal", esta seria uma solução mais genérica e duradoura, apesar de possivelmente ter uma perda de performance mas provavelmente irrelevante.

private void ChangePictureBoxes() {
    foreach (var p in Controls.OfType<PictureBox>()) p.Visible = false;
}

//http://pt.stackoverflow.com/q/17469/101
