var sr = new StreamReader(stream);
int resultado;
MessageBox.Show(int.TryParse(sr.ReadLine(), out resultado) ? resultado : "Deu algum erro no dado recebido");

//https://pt.stackoverflow.com/q/213057/101
