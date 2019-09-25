private void timer1_Tick(object sender, EventArgs e) {
    if (progressBar1.Value < 100){
        progressBar1.Value = progressBar1.Value + 2;
    } else {
        timer1.Enabled = false;
        this.Close();
        var direcionar = new Form1(); //isto provavelmente não pode estar aqui.
        direcionar.ShowDialog();
    }
}

//https://pt.stackoverflow.com/q/82179/101
