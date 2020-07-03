var arquivos = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Where(f => !f.Contains("Backup")).ToArray();

//https://pt.stackoverflow.com/q/260115/101
