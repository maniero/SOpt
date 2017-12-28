string[] Lista = new string[] { "TESTE"};

string dir = @"C:\ORIGEM";
string dir2 = @"C:\DESTINO";

private void btnQuarentena_Click(object sender, EventArgs e) {
    List<string> busca= Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).ToList();
    foreach (string item in busca) {
        var achou = false;
        //abre o arquivo "garantindo" seu fechamento no final do escopo
        using (var stream = new StreamReader(item)) {
            var arquivo = stream.ReadToEnd();
            foreach (var texto in Lista) {
                if (Regex.IsMatch(arquivo, texto)) {
                    achou = true;
                    break; //se achou não precisa mais continuar procurando
                }
            }
        }
        if (achou) {
            //não se esqueça que o using "garantiu" o fechamento do arquivo
            File.Move(item, Path.Combine(dir2, Path.GetFileName(item)));
        }
    }
}

//https://pt.stackoverflow.com/q/37362/101
