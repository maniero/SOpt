private void btnSelecionarArquivos_Click(object sender, EventArgs e) {
    OpenFileDialog fDialog = new OpenFileDialog();
    fDialog.Multiselect = true;
    fDialog.Filter = "Arquivos Texto|*.txt";
    fDialog.Title = "Selecione os Arquivos";
    if(fDialog.ShowDialog() == DialogResult.OK) MessageBox.Show(fDialog.FileNames.Aggregate((atual, proximo) => atual + ", " + proximo));
}

//https://pt.stackoverflow.com/q/118512/101
