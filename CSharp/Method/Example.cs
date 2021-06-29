static void Main(string[] args) {     
    var x = Soma(1, 2); // <==== com F10 já pula pra próxima linha, com F11 entra em Soma()
    WriteLine(x); // <==== Só entra aqui com F11 se tiver os fontes do .NET carregados
}
static int Soma(int a, int b) => a + b;

//https://pt.stackoverflow.com/q/183001/101
