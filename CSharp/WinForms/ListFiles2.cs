private void btnDiretorio_Click(object sender, EventArgs e) {
    this.grvShowFile.Rows.Clear();
    folderBrowserDialog.RootFolder = Environment.SpecialFolder.DesktopDirectory;
    folderBrowserDialog.SelectedPath = openFileDialog.InitialDirectory;
    openFileDialog.Filter = "Form (*.frm)|*.frm"; //Filtro de arquivos a serem selecionados
    DialogResult result = folderBrowserDialog.ShowDialog();
    if (result == DialogResult.OK) {
        List<string> selectedPath = Directory.GetFiles(folderBrowserDialog.SelectedPath,
                                         "*.frm", SearchOption.AllDirectories).ToList();
        foreach (string s in selectedPath) grvShowFile.Rows.Add(Path.GetFileName(s), s); //Adiciona o nome e o caminho dos arquivos nas respectivas ordens ( Bendito seja o Path.GetFileName() )
    }
}

//https://pt.stackoverflow.com/q/44010/101
