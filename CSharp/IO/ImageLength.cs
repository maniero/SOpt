long tamanho;
using (var ms = new System.IO.MemoryStream()) {
    imgFoto.Save(ms, ImageFormat.Jpeg);
    tamanho = ms.Length;
}

//https://pt.stackoverflow.com/q/41017/101
