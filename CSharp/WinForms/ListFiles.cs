public List<string> listaArquivos(string dir)
{
    List<string> lstDirs = Directory.GetDirectories(dir).ToList();
    List<string> lstFiles = Directory.GetFiles(dir, "*.frm", SearchOption.AllDirectories).ToList();
    List<string> lstFilesAux = new List<string>();
    foreach(string ldir in lstDirs)
        lstFilesAux = listaArquivos(ldir);

    lstFiles.AddRange(lstFilesAux);
    return lstFiles;
}

//https://pt.stackoverflow.com/q/44010/101
