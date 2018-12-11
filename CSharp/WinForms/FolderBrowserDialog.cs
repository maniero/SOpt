List<string> selectedPath = listaArquivos(folderBrowserDialog.SelectedPath);
foreach (string s in selectedPath) {
    grvShowFile.Rows.Add(Path.GetFileName(s));
}

//https://pt.stackoverflow.com/q/43996/101
