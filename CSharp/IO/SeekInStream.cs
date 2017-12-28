using (FileStream fs = new FileStream(@"file.txt", FileMode.Open, FileAccess.Read)) {
    fs.Seek(100, SeekOrigin.Begin); //100 é a posição onde inicia a linha desejada
    byte[] buffer = new byte[200]; //nada garante que a linha não seja maior que 200
    fs.Read(buffer, 0, 200));
}

//https://pt.stackoverflow.com/q/37285/101
