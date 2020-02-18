buttonAbrirConexão.Enabled = false;
TcpListener servidor = new TcpListener(6554);
servidor.Start();
while(true) {
    MessageBox.Show("Cliente conectado");
    Socket conexão = await servidor.AcceptSocketAsync();
    socketStream = new NetworkStream(conexão);
    escrever = new BinaryWriter(socketStream);
    ler = new BinaryReader(socketStream);
    escrever.Write("Alguma coisa");
}

//https://pt.stackoverflow.com/q/149527/101
