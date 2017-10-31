byte[] array = File.ReadAllBytes(@"C:\programa.exe");

//

var path = @"C:\programa.exe"
BinaryReader reader = new BinaryReader(path);
//não é muito elegante, pode dar problema em casos extremos
//mas tentar carregar arquivos inteiros na memória sempre pode dar problema
//truque para ler todos os bytes até o final
byte[] buffer = reader.ReadBytes((int)new FileInfo(path).Length));
reader.Close();

//

var fs = new FileStream(@"C:\programa.exe", FileMode.OpenOrCreate, FileAccess.Read);
byte[] buffer= new byte[fs.Length];
fs.Read(buffer, 0, Convert.ToInt32(fs.Length);
fs.Close();

//

using (var fs = new FileStream(@"C:\programa.exe", FileMode.OpenOrCreate, FileAccess.Read)) {
    byte[] buffer= new byte[fs.Length];
    fs.Read(buffer, 0, Convert.ToInt32(fs.Length);
}

//https://pt.stackoverflow.com/q/37212/101
