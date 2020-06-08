using (var sw = new StringWriter())
using (var tw = new XmlTextWriter(sw))
using (var arquivo = new FileStream("C:\\" + chave_nfe + "-NFe.xml", FileMode.CreateNew) {
    // ... faz o que deve aqui
}

//Em C# 8 já pode fazer:

using var sw = new StringWriter());
using var tw = new XmlTextWriter(sw));
using var arquivo = new FileStream("C:\\" + chave_nfe + "-NFe.xml", FileMode.CreateNew);
// ... faz o que deve aqui

//https://pt.stackoverflow.com/q/230130/101
