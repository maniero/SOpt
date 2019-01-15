using System;
using System.Windows.Forms;

public class HelloWorld : Form {
    static public void Main() {
        Application.Run(new HelloWorld());
    }

    public HelloWorld() {
        this.Text = "Minha Janela";
        Button b = new Button();
        b.Text = "Click aqui";
        b.Click += new EventHandler(Button_Click);
        Controls.Add(b);
    }

    private void Button_Click(object sender, EventArgs e) {
        MessageBox.Show("Clicou!");
    }
}

//https://pt.stackoverflow.com/q/44716/101
