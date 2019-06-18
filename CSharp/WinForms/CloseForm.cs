private void frmAgent_FormClosing(object sender, FormClosingEventArgs e) {       
    if (MessageBox.Show("Deseja realmente fechar o sistema?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) {                
        e.Cancel = true;
    }
}

//https://pt.stackoverflow.com/q/47890/101
