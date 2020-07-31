objeto.Escrever => Write($"Tenho um texto para te dizer: {texto}");

objeto.Escrever()

public readonly Action<string> Escrever;

this.Escrever = (texto) => WriteLine(texto);

public readonly Action<string> Escrever = (texto) => WriteLine(texto);

public static readonly Action<string> Escrever = (texto) => WriteLine(texto);

public void Escrever(texto) => WriteLine(texto);

public Func<int, int, int> Soma = (n1, n2) => n1 + n2;

public int Soma(int n1, int n2) => n1 + n2;

//https://pt.stackoverflow.com/q/324158/101
