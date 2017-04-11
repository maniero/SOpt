FolderBrowserDialog fbd = new FolderBrowserDialog();
DialogResult result = fbd.ShowDialog();
string[] files = Directory.GetFiles(fbd.SelectedPath, "*.xls");
System.Windows.Forms.MessageBox.Show("Arquivos na Pasta: " + files.Length.ToString(), "Alerta");

//Uma opção melhor para .Net 4.5:

FolderBrowserDialog fbd = new FolderBrowserDialog();
DialogResult result = fbd.ShowDialog();
string[] files = Directory.EnumerateFiles(path)
                         .Where(file => file.ToLower().EndsWith("xls") ||
                                        file.ToLower().EndsWith("xlsx"))
System.Windows.Forms.MessageBox.Show("Arquivos na Pasta: " + files.Length.ToString(), "Alerta");

//

public static string[] GetFiles(string sourceFolder, string filters, System.IO.SearchOption searchOption) {
   return filters.Split('|').SelectMany(filter =>
          System.IO.Directory.GetFiles(sourceFolder, filter, searchOption)).ToArray();
}

//http://pt.stackoverflow.com/q/30797/101
