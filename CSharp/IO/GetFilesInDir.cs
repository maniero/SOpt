foreach (var file in Directory.GetFiles("c:\\ImgRoute\\Caixa9 D1\\", "*.*")) {
    var imag = Path.GetFileNameWithoutExtension(file);
    if (imag.Length == 16) {
        //("Numero do auto correto");
    } else {
        //("Numero do auto invalido");
    }
}

//https://pt.stackoverflow.com/q/46191/101
