arquivosFiltrados = listaArquivos.Where(x => x.Modified.Compare(UltimoHorario) > 0)

arquivosFiltrados = listaArquivos.Where(x => ValidarArquivo(x))

//https://pt.stackoverflow.com/q/74019/101
