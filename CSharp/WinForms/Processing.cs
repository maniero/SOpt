public partial class IdadeForm : Form {
   private int Entrados = 1, Maiores;
   public idade() {
       InitializeComponent();
   }

   private void button1_Click(object sender, EventArgs e) {
       if (!int.TryParse(txtidade1.Text, ou var idade)) {
           MessageBox.Show("A idade digitada não é válida");
           return;
       }
       if (idade > 17) Maiores++;
       lblMaiores.Text = $"O maiores de idade contados são {Maiores}";
       lblIdade.Text = $"Digite a idade {++Entrados}:";
       if (Entrados == 10) //lógica que não permite mais entrar dados ou reset
    }
}

//https://pt.stackoverflow.com/q/306449/101
