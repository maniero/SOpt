foreach (var arquivo in Directory.GetFiles(@"C:\temp\ae", "*.exe", SearchOption.TopDirectoryOnly) {
    if (Path.GetFileName(arquivo) != "teste.exe") File.Delete(arquivo);
}

foreach (var arquivo in Directory.EnumerateFiles(@"C:\temp\ae", "*.exe", SearchOption.TopDirectoryOnly).Where(f => Path.GetFileName(f) != "teste.exe") File.Delete(arquivo);

//https://pt.stackoverflow.com/q/302589/101
